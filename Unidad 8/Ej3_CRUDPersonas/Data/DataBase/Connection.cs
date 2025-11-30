using System;

namespace Data.Database
{
    /// <summary>
    /// Clase encargada de gestionar la cadena de conexión a la base de datos Azure.
    /// Se utiliza desde los repositorios para poder establecer una conexión con la BBDD.
    /// </summary>
    public static class Connection
    {
        /// <summary>
        /// Método estático que devuelve la cadena de conexión necesaria
        /// para conectarse a la base de datos en Azure.
        /// </summary>
        /// <returns>Cadena de conexión completa.</returns>
        public static string GetConnectionString()
        {
            return "server=jlbarrionuevo.database.windows.net;database=PersonaDB;uid=prueba;pwd=abcd1234!;trustServerCertificate = true;";
        }
    }
}

