using System.Data.SqlClient;

public class DatabaseManager
{
    private string connectionString;

    public DatabaseManager(string dataSource, string initialCatalog)
    {
        // Construir la cadena de conexión usando el origen de datos y el catálogo inicial proporcionados
        connectionString = $"Data Source={dataSource}; Initial Catalog={initialCatalog}; Integrated Security=True";
    }

    public int GetUserCount(string nombre, string contrasena)
    {
        int count = 0;

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open(); // Abrir la conexión

            // Consulta SQL con parámetros
            string query = "SELECT COUNT(*) FROM usuario WHERE nombre = @nombre AND contraseÑa = @contrasena";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Agregar parámetros para evitar la inyección de SQL
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@contrasena", contrasena);

                // Ejecutar la consulta y obtener el resultado
                count = (int)command.ExecuteScalar();
            }
        }

        return count;
    }
}


// Crear una instancia de DatabaseManager
