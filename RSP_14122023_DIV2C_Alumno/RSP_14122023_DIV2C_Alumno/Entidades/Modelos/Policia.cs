using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Interfaces;
using System.Linq;

namespace Entidades.Modelos
{
    public class Policia : IServidorPublico
    {

        private static List<EEmergencia> emergenciasAtendibles;

        static Policia()
        {
            Policia.emergenciasAtendibles = new List<EEmergencia>() { EEmergencia.Accidentes_De_Trafico, EEmergencia.Rescates };
        }

        public string Imagen { get { return $"./assets/{this.GetType().Name}.gif"; }  } 

        public void Atender(Emergencia emergencia)
        {
            if (!emergenciasAtendibles.Any(e => e.Equals(emergencia)))
            {
                throw new ServidorPublicoInvalidoException("El servidor publico no puede atender este tipo de emergencias");
            }
        }
    }
}
