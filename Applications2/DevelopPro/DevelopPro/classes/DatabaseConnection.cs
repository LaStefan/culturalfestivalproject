using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DevelopPro.classes
{
    class DatabaseConnection
    {
        MySqlConnection connection;


        public DatabaseConnection()
        {
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi401148;" +
                                    "user id=dbi401148;" +
                                    "password=123456789;";

            connection = new MySqlConnection(connectionInfo);
        }
    }
}
