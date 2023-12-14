using System.Text.Json;

namespace Entidades.Archivos
{
    public static class GestorDeArchivos
    {
        private static string basePath;

        static GestorDeArchivos()
        {
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullPath = Path.Combine(pathDesktop, "RSP_14122023");
            GestorDeArchivos.basePath = fullPath;
            ValidarExistenciaDeDirectorio();

        }

        private static void ValidarExistenciaDeDirectorio()
        {
            try
            {
                if (Directory.Exists(GestorDeArchivos.basePath))
                {
                    Directory.CreateDirectory(GestorDeArchivos.basePath);
                }
            }
            catch (Exception)
            {

            }

        }

        // Dentro del catch no hago nada pq no tengo una excepcion especifica para lanzar en la consigna
        public static void Guardar(string informacion, string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    File.WriteAllText(informacion, path);
                }
            }
            catch (Exception ex)
            {

            }
        }



        public static void SerializarAJson<T>(T objeto)
        {
            try
            {
                string jsonSerializado = JsonSerializer.Serialize(objeto);
                GestorDeArchivos.Guardar(jsonSerializado, GestorDeArchivos.basePath + " \\Serializador.JSON");
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
