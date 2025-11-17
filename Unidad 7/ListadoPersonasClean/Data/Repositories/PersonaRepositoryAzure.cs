using Domain.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{

    public class PersonaRepositoryAzure : IPersonaRepository
    {
        public List<Persona> GetListadoPersonas()
        {

            SqlConnection miConexion = new SqlConnection();

            List<Persona> listadoPersonas = new List<Persona>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            clsPersona oPersona;

            miConexion.ConnectionString
            = ("server=localhost;database=nombreBBDD;uid=prueba;pwd=123;trustServerCertificate=true;“


            try

            {

                miConexion.Open();

                //Creamos el comando (Creamos el comando, le pasamos la sentencia y la conexion, y
                lo ejecutamos)

miComando.CommandText = "SELECT * FROM personas";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();
                miLector = miComando.ExecuteReader();

            }
    }   