using Entidades.Enumerados;

namespace Entidades.Modelos
{
    public class Policia
    {

        private static List<EEmergencia> emergenciasAtendibles;

        static Policia()
        {
            Policia.emergenciasAtendibles = new List<EEmergencia>() { EEmergencia.Accidentes_De_Trafico, EEmergencia.Rescates };
        }

    }
}
