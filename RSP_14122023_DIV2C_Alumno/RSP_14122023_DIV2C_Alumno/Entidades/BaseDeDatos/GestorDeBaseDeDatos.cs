using Entidades.Excepciones;
using System.Data.SqlClient;

namespace Entidades.BaseDeDatos
{
    public static class GestorDeBaseDeDatos
    {

        private static SqlConnection connection;
        private static string stringConnection;

        static GestorDeBaseDeDatos()
        {
            GestorDeBaseDeDatos.stringConnection = "Server = ALE; Database = 14122023-rsp; Trusted_Connection = True;";
        }

        public static bool RegistrarTrabajo(string nombreDelAlumno, int cantidadPacientes)
        {
            using (SqlConnection connection = new SqlConnection(GestorDeBaseDeDatos.stringConnection))
            {
                try
                {
                    string query = "INSERT INTO log (pacientes_atendidos,alumno) VALUES(@cantidadPacientes,@nombreDelAlumno)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombreDelAlumno", nombreDelAlumno);
                    command.Parameters.AddWithValue("@cantidadPacientes", cantidadPacientes);

                    connection.Open();

                    int resultado  = command.ExecuteNonQuery();

                    // Si se afecta alguna fila retornamos true, significando que se pudo escribir
                    if (resultado > 0)
                    {
                        return true;
                    }
                    else return false;
                }
                catch (Exception ex)
                {
                    throw new ServidorPublicoInvalidoException("Error al escribir  en la Base de datos", ex);
                }
            }

        }



    }
}
