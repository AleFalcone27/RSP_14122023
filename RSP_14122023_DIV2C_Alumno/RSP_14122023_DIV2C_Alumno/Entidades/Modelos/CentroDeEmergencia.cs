using Entidades.Delegados;
using Entidades.Enumerados;
using Entidades.Interfaces;
using System;

namespace Entidades.Modelos
{


    public class CentroDeEmergencia
    {
        private string nombre;
        private Emergencia emergenciaEnCurso;
        private List<Emergencia> emergenciasAtendidas;
        private CancellationTokenSource cancellation;
        private Random random;

        public event DelegadoEmergenciaEnCurso OnEmergenciaEnCurso;
        public event DelegadoEstadoEmergenciaEnCurso OnEstadoEmergenciaEnCurso;

        public CentroDeEmergencia(string nombre)
        {
            this.nombre = nombre;
            this.emergenciasAtendidas = new List<Emergencia>();
        }

        public string Nombre { get => this.nombre; }
        public List<Emergencia> EmergenciasAtendidas { get => this.emergenciasAtendidas; }

        public void HabilitarIngreso()
        {
            Task.Run(() => { 
            
                while (!cancellation.IsCancellationRequested)
                {
                    while (!cancellation.Token.IsCancellationRequested)
                    {

                        Array values = Enum.GetValues(typeof(EEmergencia));
                        int index = this.random.Next(values.Length);
                        this.emergenciaEnCurso = new Emergencia((EEmergencia)values.GetValue(index));

                        OnEmergenciaEnCurso.Invoke(this.emergenciaEnCurso);

                        DarSeguimientoAEmergencia();
                    }
                }

            },cancellation.Token);

        }

        private void DarSeguimientoAEmergencia()
        {
            Task.Run(() =>
            {
                while (!cancellation.IsCancellationRequested && this.emergenciaEnCurso.SegundosTranscurridos > Emergencia.TiempoLimiteEnSegundos && this.emergenciaEnCurso.EstaAtendida == false)

                {
                    Thread.Sleep(1000);
                    this.emergenciaEnCurso.ActualizarEstadoEmergencia();
                    NotificarEstadoDeEmergenciaEnCurso();
                }

            });

        }


        public void EnviarServidorPublico<T>(T servidorPublico) where T : IServidorPublico
        {

            Task.Run(() => {

                Thread.Sleep(3000);
                servidorPublico.Atender(this.emergenciaEnCurso);
                servidorPublico
            
            });


        }

        public void DeshabilitarIngreso()
        {
            cancellation.Cancel();
        }

        private void NotificarEstadoDeEmergenciaEnCurso()
        {
            OnEstadoEmergenciaEnCurso.Invoke(this.emergenciaEnCurso.EstadoEmergencia);
        }
    }
}
