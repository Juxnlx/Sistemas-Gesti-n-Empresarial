using Data.DataBase;
using Domain.Entities;
using Domain.RepositoriesInterfaces;
using Microsoft.Data.SqlClient;

namespace Data.Repositories 
{
    // Implementa IDepartamentoRepository
    public class DepartamentoRepositoryAzure : IDepartamentoRepository
    {
        #region ListadoDepartamentos
        
        public List<clsDepartamento> GetAll()
        {
            var departamentos = new List<clsDepartamento>();
            string connectionString = clsConnection.GetConnectionString();
            string sql = "SELECT ID, Nombre FROM Departamentos";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        departamentos.Add(new clsDepartamento
                        {
                            ID = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }
            }
            return departamentos;
        }
        #endregion

        #region Insert
        
        public int Insert(clsDepartamento departamento)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = "INSERT INTO Departamentos (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Nombre", departamento.Nombre);
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        #endregion

        #region Update
        
        public int Update(clsDepartamento departamento)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = "UPDATE Departamentos SET Nombre = @Nombre WHERE ID = @ID";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Nombre", departamento.Nombre);
                command.Parameters.AddWithValue("@ID", departamento.ID);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Delete

        public bool Delete(int id)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = "DELETE FROM Departamentos WHERE ID = @ID";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        #endregion

        #region DepartamentoPorID
        
        public clsDepartamento GetById(int id)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = "SELECT ID, Nombre FROM Departamentos WHERE ID = @ID";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new clsDepartamento
                        {
                            ID = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };
                    }
                }
            }
            return null;
        }
        #endregion

        #region CountDepartamentosPorNombre
        
        public int CountByName(string nombre)
        {
            string connectionString = clsConnection.GetConnectionString();
            string sql = "SELECT COUNT(*) FROM Departamentos WHERE Nombre = @Nombre";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Nombre", nombre);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
        #endregion
    }
}

