using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace shopApp
{
    class DbConnect
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
    }
}
