
namespace Data.DataBase
{
    public class clsConnection
    {
        /// <summary>
        /// Conexión a la base de datos Azure SQL PersonasDB
        /// </summary>
        /// <returns>Todos los datos del servidor</returns>
        public static string GetConnectionString()
        {
            return "server=jlbarrionuevo.database.windows.net;database=PersonasDB;uid=prueba;pwd=.abcd1234!;trustServerCertificate = true;";
        }
    }
}
