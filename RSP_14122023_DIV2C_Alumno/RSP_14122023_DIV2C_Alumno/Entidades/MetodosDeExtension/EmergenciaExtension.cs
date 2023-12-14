using Entidades.Enumerados;

namespace Entidades.MetodosDeExtension
{
    public static class EmergenciaExtension
    {

        public static bool ValidarEmergencia(this List<EEmergencia> lista, EEmergencia eEmergencia)
        {
            if (lista.Any(emergencia => emergencia == eEmergencia))
            {
                return true;
            }
            else return false;
        }
    }
}
