using Entidades.Interfaces;

namespace Entidades.Modelos
{


    public class CentroDeEmergencia
    {

        private string nombre;
        private Emergencia emergenciaEnCurso;
        private List<Emergencia> emergenciasAtendidas;
        public CentroDeEmergencia(string nombre)
        {
            this.nombre = nombre;
            this.emergenciasAtendidas = new List<Emergencia>();
        }

        public string Nombre { get => this.nombre; }
        public List<Emergencia> EmergenciasAtendidas { get => this.emergenciasAtendidas; }

        public void HabilitarIngreso()
        {


        }

        private void DarSeguimientoAEmergencia()
        {

        }


        public void EnviarServidorPublico<T>(T servidorPublico) where T : IServidorPublico
        {


        }

        public void DeshabilitarIngreso()
        {

        }

        private void NotificarEstadoDeEmergenciaEnCurso()
        {

        }
    }
}
