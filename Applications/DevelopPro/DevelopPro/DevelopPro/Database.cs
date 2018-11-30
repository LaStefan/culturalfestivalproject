using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DevelopPro
{
   public class Database
    {
        
        private MySqlConnection conn;
        
        public Database()
        {
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                   "database=dbi401148;" +
                                    "user id=dbi401148;" +
                                    "password=123456789;";
            conn = new MySqlConnection(connectionInfo);
        }
        private string sqlExceptionMessage(string originalExceptionMessage)
        {
            return (
                "For regular users: Database problem detected" +
                "\n\n" +
                "For developers: " + originalExceptionMessage
                );
        }
        //testing method!
        public int GetVisitorNumber()
        {
            int nr=0;
            String sql = "SELECT COUNT(*) FROM employee";
            MySqlCommand command = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                
                nr = Convert.ToInt32(command.ExecuteScalar());
                
            }catch(MySqlException ex)
            {
                MessageBox.Show(sqlExceptionMessage(ex.ToString()));
            }
            finally
            {
                conn.Close();
            }
            return nr;
        }

    }
}
