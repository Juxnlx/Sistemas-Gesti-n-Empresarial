using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Data.DataBase;

namespace Data.Repositories.RepositoriosPersona
{
    /// <summary>
    /// Repositorio que implementa IPersonaRepository para acceder a la tabla Personas
    /// de la base de datos en Azure. Incluye todos los métodos CRUD.
    /// </summary>
    public class PersonaRepositoryAzure : IPersonaRepository
    {
        /// <summary>
        /// Devuelve una lista de todas las personas de la BBDD.
        /// </summary>
        /// <returns>Lista de objetos Persona</returns>
        public List<Persona> getListaPersonas()
        {
            List<Persona> listadoPersonas = new List<Persona>();

            // Creamos la conexión
            SqlConnection miConexion = new SqlConnection();
            miConexion.ConnectionString = Connection.getConnectionString();

            // Creamos el comando SQL
            SqlCommand miComando = new SqlCommand
            {
                Connection = miConexion,
                CommandText = "SELECT * FROM Personas"
            };

            try
            {
                miConexion.Open();

                SqlDataReader miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        Persona oPersona = new Persona();

                        // Mapeamos todos los campos de la tabla a la entidad
                        oPersona.ID = (int)miLector["ID"];
                        oPersona.Nombre = (string)miLector["Nombre"];
                        oPersona.Apellidos = (string)miLector["Apellidos"];
                        oPersona.Telefono = miLector["Telefono"] != DBNull.Value ? (string)miLector["Telefono"] : "";
                        oPersona.Direccion = miLector["Direccion"] != DBNull.Value ? (string)miLector["Direccion"] : "";
                        oPersona.Foto = miLector["Foto"] != DBNull.Value ? (string)miLector["Foto"] : "";
                        oPersona.FechaNacimiento = miLector["FechaNacimiento"] != DBNull.Value ? (DateTime)miLector["FechaNacimiento"] : DateTime.MinValue;
                        oPersona.IDDepartamento = miLector["IDDepartamento"] != DBNull.Value ? (int)miLector["IDDepartamento"] : 0;

                        listadoPersonas.Add(oPersona);
                    }
                }

                miLector.Close();
                miConexion.Close();
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listadoPersonas;
        }

        /// <summary>
        /// Devuelve una persona específica por ID.
        /// </summary>
        /// <param name="idPersona">ID de la persona a buscar</param>
        /// <returns>Objeto Persona o null si no existe</returns>
        public Persona getPersonaPorId(int idPersona)
        {
            Persona personaEncontrada = null;

            List<Persona> listaDePersonas = getListaPersonas();

            foreach (Persona persona in listaDePersonas)
            {
                if (persona.ID == idPersona)
                {
                    personaEncontrada = persona;
                    break;
                }
            }

            return personaEncontrada;
        }

        /// <summary>
        /// Crea una nueva persona en la BBDD.
        /// </summary>
        /// <param name="personaNueva">Objeto Persona con los datos a insertar</param>
        /// <returns>Número de filas afectadas</returns>
        public int crearPersona(Persona personaNueva)
        {
            int filasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection
            {
                ConnectionString = Connection.getConnectionString()
            };

            SqlCommand miComando = new SqlCommand
            {
                Connection = miConexion,
                CommandText = "INSERT INTO Personas (Nombre, Apellidos, Telefono, Direccion, Foto, FechaNacimiento, IDDepartamento) " +
                              "VALUES (@Nombre, @Apellidos, @Telefono, @Direccion, @Foto, @FechaNacimiento, @IDDepartamento)"
            };

            // Parámetros
            miComando.Parameters.AddWithValue("@Nombre", personaNueva.Nombre);
            miComando.Parameters.AddWithValue("@Apellidos", personaNueva.Apellidos);
            miComando.Parameters.AddWithValue("@Telefono", personaNueva.Telefono);
            miComando.Parameters.AddWithValue("@Direccion", personaNueva.Direccion);
            miComando.Parameters.AddWithValue("@Foto", personaNueva.Foto);
            miComando.Parameters.AddWithValue("@FechaNacimiento", personaNueva.FechaNacimiento);
            miComando.Parameters.AddWithValue("@IDDepartamento", personaNueva.IDDepartamento);

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
        /// Actualiza una persona existente en la BBDD.
        /// </summary>
        /// <param name="idPersona">ID de la persona a actualizar</param>
        /// <param name="persona">Objeto Persona con los nuevos datos</param>
        /// <returns>Número de filas afectadas</returns>
        public int actualizarPersona(int idPersona, Persona persona)
        {
            int filasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection
            {
                ConnectionString = Connection.getConnectionString()
            };

            SqlCommand miComando = new SqlCommand
            {
                Connection = miConexion,
                CommandText = "UPDATE Personas SET " +
                              "Nombre = @Nombre, " +
                              "Apellidos = @Apellidos, " +
                              "Telefono = @Telefono, " +
                              "Direccion = @Direccion, " +
                              "Foto = @Foto, " +
                              "FechaNacimiento = @FechaNacimiento, " +
                              "IDDepartamento = @IDDepartamento " +
                              "WHERE ID = @IDPersona"
            };

            // Parámetros
            miComando.Parameters.AddWithValue("@IDPersona", idPersona);
            miComando.Parameters.AddWithValue("@Nombre", persona.Nombre);
            miComando.Parameters.AddWithValue("@Apellidos", persona.Apellidos);
            miComando.Parameters.AddWithValue("@Telefono", persona.Telefono);
            miComando.Parameters.AddWithValue("@Direccion", persona.Direccion);
            miComando.Parameters.AddWithValue("@Foto", persona.Foto);
            miComando.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento);
            miComando.Parameters.AddWithValue("@IDDepartamento", persona.IDDepartamento);

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
        /// Elimina una persona específica de la BBDD por ID.
        /// </summary>
        /// <param name="idPersona">ID de la persona a eliminar</param>
        /// <returns>Número de filas afectadas</returns>
        public int eliminarPersona(int idPersona)
        {
            int filasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection
            {
                ConnectionString = Connection.getConnectionString()
            };

            SqlCommand miComando = new SqlCommand
            {
                Connection = miConexion,
                CommandText = "DELETE FROM Personas WHERE ID = @ID"
            };

            miComando.Parameters.AddWithValue("@ID", idPersona);

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
    }
}

