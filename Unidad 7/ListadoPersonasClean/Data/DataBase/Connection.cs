using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{
    internal class Connection
    {
        public static String getConnectionString()
        {
            return "server=jlbarrionuevo.database.windows.net;database=PersonaDB;uid=prueba;pwd=.abcd1234!;trustServerCertificate = true;";
        }
    }
}
