using Domain.Entities;
using Domain.RepositoriesInterfaces;
using Microsoft.Data.SqlClient;
using Data.DataBase;

namespace Data.Repositories
{
    // Implementa IPersonaRepository
    public class PersonaRepositoryAzure : IPersonaRepository
    {
        #region ListadoPersonas
       
        public List<clsPersona> GetAll()
        {
            var personas = new List<clsPersona>();
            string connectionString = clsConnection.GetConnectionString(); // Uso de la clase estática
            string sql = "SELECT ID, Nombre, Apellidos, Telefono, Direccion, FechaNacimiento, IDDepartamento FROM Personas";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        personas.Add(new clsPersona
                        {
                            ID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellidos = reader.GetString(2),
                            // Manejo de valores DBNull
                            Telefono = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Direccion = reader.IsDBNull(4) ? null : reader.GetString(4),
                            FechaNacimiento = reader.GetDateTime(5),
                            IDDepartamento = reader.GetInt32(6)
                        });
                    }
                }
            }
            return personas;
        }
        #endregion

        #region Insert
        
        public int Insert(clsPersona persona)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = @"
            INSERT INTO Personas (Nombre, Apellidos, Telefono, Direccion, FechaNacimiento, IDDepartamento) 
            VALUES (@Nombre, @Apellidos, @Telefono, @Direccion, @FechaNacimiento, @IDDepartamento); 
            SELECT SCOPE_IDENTITY();";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Apellidos", persona.Apellidos);
                command.Parameters.AddWithValue("@Telefono", (object)persona.Telefono ?? DBNull.Value);
                command.Parameters.AddWithValue("@Direccion", (object)persona.Direccion ?? DBNull.Value);
                command.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento);
                command.Parameters.AddWithValue("@IDDepartamento", persona.IDDepartamento);

                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        #endregion

        #region Update
        
        public int Update(clsPersona persona)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = @"
            UPDATE Personas 
            SET Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, 
                Direccion = @Direccion, FechaNacimiento = @FechaNacimiento, IDDepartamento = @IDDepartamento
            WHERE ID = @ID";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Apellidos", persona.Apellidos);
                command.Parameters.AddWithValue("@Telefono", (object)persona.Telefono ?? DBNull.Value);
                command.Parameters.AddWithValue("@Direccion", (object)persona.Direccion ?? DBNull.Value);
                command.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento);
                command.Parameters.AddWithValue("@IDDepartamento", persona.IDDepartamento);
                command.Parameters.AddWithValue("@ID", persona.ID);

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Delete
        
        public bool Delete(int id)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = "DELETE FROM Personas WHERE ID = @ID";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        #endregion

        #region PersonaPorID
        
        public clsPersona GetById(int id)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = "SELECT ID, Nombre, Apellidos, Telefono, Direccion, FechaNacimiento, IDDepartamento FROM Personas WHERE ID = @ID";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsPersona
                        {
                            ID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellidos = reader.GetString(2),
                            Telefono = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Direccion = reader.IsDBNull(4) ? null : reader.GetString(4),
                            FechaNacimiento = reader.GetDateTime(5),
                            IDDepartamento = reader.GetInt32(6)
                        };
                    }
                }
            }
            return null;
        }
        #endregion

        #region CountPersonasByDepartamento
        
        public int CountByDepartamentoId(int idDepartamento)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = "SELECT COUNT(*) FROM Personas WHERE IDDepartamento = @IDDepartamento";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@IDDepartamento", idDepartamento);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
        #endregion
    }
}
