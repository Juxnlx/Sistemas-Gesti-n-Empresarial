using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Data.DataBase;

namespace Data.Repositories.RepositorioDepartamento
{
    /// <summary>
    /// Repositorio que implementa IDepartamentoRepository para acceder a la tabla Departamentos
    /// de la base de datos en Azure. Incluye todos los métodos CRUD y la regla de negocio
    /// que impide borrar un departamento que tenga personas.
    /// </summary>
    public class DepartamentoRepositoryAzure : IDepartamentoRepository
    {
        /// <summary>
        /// Devuelve una lista de todos los departamentos de la BBDD.
        /// </summary>
        /// <returns>Lista de objetos Departamento</returns>
        public List<Departamento> getListaDepartamentos()
        {
            List<Departamento> listadoDepartamentos = new List<Departamento>();

            SqlConnection miConexion = new SqlConnection
            {
                ConnectionString = Connection.getConnectionString()
            };

            SqlCommand miComando = new SqlCommand
            {
                Connection = miConexion,
                CommandText = "SELECT * FROM Departamentos"
            };

            try
            {
                miConexion.Open();

                SqlDataReader miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        Departamento oDepartamento = new Departamento
                        {
                            ID = (int)miLector["ID"],
                            nombre = (string)miLector["Nombre"]
                        };

                        listadoDepartamentos.Add(oDepartamento);
                    }
                }

                miLector.Close();
                miConexion.Close();
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listadoDepartamentos;
        }

        /// <summary>
        /// Devuelve un departamento específico por ID.
        /// </summary>
        /// <param name="idDepartamento">ID del departamento a buscar</param>
        /// <returns>Objeto Departamento o null si no existe</returns>
        public Departamento getDepartamentoPorId(int idDepartamento)
        {
            Departamento departamentoEncontrado = null;

            List<Departamento> listaDepartamentos = getListaDepartamentos();

            foreach (Departamento dept in listaDepartamentos)
            {
                if (dept.ID == idDepartamento)
                {
                    departamentoEncontrado = dept;
                    break;
                }
            }

            return departamentoEncontrado;
        }

        /// <summary>
        /// Crea un nuevo departamento en la BBDD.
        /// </summary>
        /// <param name="departamentoNuevo">Objeto Departamento con los datos a insertar</param>
        /// <returns>Número de filas afectadas</returns>
        public int crearDepartamento(Departamento departamentoNuevo)
        {
            int filasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection
            {
                ConnectionString = Connection.getConnectionString()
            };

            SqlCommand miComando = new SqlCommand
            {
                Connection = miConexion,
                CommandText = "INSERT INTO Departamentos (Nombre) VALUES (@Nombre)"
            };

            miComando.Parameters.AddWithValue("@Nombre", departamentoNuevo.nombre);

            try
            {
                miConexion.Open();
                filasAfectadas = miComando.ExecuteNonQuery();
                miConexion.Close();
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return filasAfectadas;
        }

        /// <summary>
        /// Actualiza un departamento existente en la BBDD.
        /// </summary>
        /// <param name="idDepartamento">ID del departamento a actualizar</param>
        /// <param name="departamento">Objeto Departamento con los nuevos datos</param>
        /// <returns>Número de filas afectadas</returns>
        public int actualizarDepartamento(int idDepartamento, Departamento departamento)
        {
            int filasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection
            {
                ConnectionString = Connection.getConnectionString()
            };

            SqlCommand miComando = new SqlCommand
            {
                Connection = miConexion,
                CommandText = "UPDATE Departamentos SET Nombre = @Nombre WHERE ID = @IDDepartamento"
            };

            miComando.Parameters.AddWithValue("@IDDepartamento", idDepartamento);
            miComando.Parameters.AddWithValue("@Nombre", departamento.nombre);

            try
            {
                miConexion.Open();
                filasAfectadas = miComando.ExecuteNonQuery();
                miConexion.Close();
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return filasAfectadas;
        }

        /// <summary>
        /// Elimina un departamento de la BBDD si no tiene personas asociadas.
        /// </summary>
        /// <param name="idDepartamento">ID del departamento a eliminar</param>
        /// <returns>Número de filas afectadas</returns>
        public int eliminarDepartamento(int idDepartamento)
        {
            int filasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection
            {
                ConnectionString = Connection.getConnectionString()
            };

            try
            {
                // Primero comprobamos si hay personas asociadas
                SqlCommand contarPersonas = new SqlCommand
                {
                    Connection = miConexion,
                    CommandText = "SELECT COUNT(*) FROM Personas WHERE IDDepartamento = @IDDepartamento"
                };
                contarPersonas.Parameters.AddWithValue("@IDDepartamento", idDepartamento);

                miConexion.Open();
                int cantidadPersonas = (int)contarPersonas.ExecuteScalar();

                if (cantidadPersonas > 0)
                {
                    // No se puede borrar, devolvemos 0 filas afectadas
                    miConexion.Close();
                    return 0;
                }

                // Si no hay personas, borramos el departamento
                SqlCommand miComando = new SqlCommand
                {
                    Connection = miConexion,
                    CommandText = "DELETE FROM Departamentos WHERE ID = @IDDepartamento"
                };
                miComando.Parameters.AddWithValue("@IDDepartamento", idDepartamento);

                filasAfectadas = miComando.ExecuteNonQuery();
                miConexion.Close();
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return filasAfectadas;
        }
    }
}
