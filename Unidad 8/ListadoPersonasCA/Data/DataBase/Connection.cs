using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{
    internal class Connection
    {
        public static string getConnectionString() {
           return "server=jlbarrionuevo.database.windows.net;database=PersonasDB;uid=prueba;pwd=.abcd1234!;trustServerCertificate = true;";
        }
    }
}
