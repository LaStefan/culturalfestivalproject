using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using DevelopPro;
namespace Reservation
{
    public class DatabaseConnector
    {
        private MySqlConnection connectionToDB;   

        public DatabaseConnector()
        {
            String connectionInfo = "Server=studmysql01.fhict.local;" +
                                  "Database=dbi401148;" +
                                   "Uid=dbi401148;" +
                                   "Pwd=123456789;";
            
            connectionToDB = new MySqlConnection(connectionInfo);
        }
      
        public List<CampingSite> GetAllCampingSites()
        {
            List<CampingSite> campingSites = new List<CampingSite>();

            int campId = 0;
            string campType = "";
            string status;
            string sql = "SELECT CampingSiteId, CampingType,Status FROM campingsite";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);

            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    campId = Convert.ToInt32(reader["CampingSiteId"]);
                    campType = Convert.ToString(reader["CampingType"]);
                    status = Convert.ToString(reader["Status"]);

                    campingSites.Add(new CampingSite(campId, campType, status));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connectionToDB.Close();
            }

            return campingSites;
        }

        public void ReserveCamp(int campId ,string startDate, string endDate)
        {
            string sql = "UPDATE campingsite SET StartDate=@startDate, EndDate=@endDate, Status=1 WHERE CampingSiteId=@campId";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            command.Parameters.AddWithValue("@campId", campId);
            try
            {
                int update;
         
                connectionToDB.Open();
                update = command.ExecuteNonQuery();

                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connectionToDB.Close();
            }
        }

        public bool CheckStatus(int campId)
        {
            int status;
            string sql = "SELECT Status FROM campingsite WHERE CampingSiteId=@campId";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@campId", campId);

            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    status = Convert.ToInt32(reader["Status"]);  
                    if(status == 1)
                    {
                        return true;
                    }
                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connectionToDB.Close();
            }

            return false;
        }

        public string GetInfo(string tag)
        {
            string holder;
            String fname = "";
            String lname = "";
            String email = "";
            decimal balance = 0;
            String ticket = "";
            String status = "";
            String sql = "SELECT CustomerId, FirstName, LastName,Email,Balance,TicketType,Status FROM customer WHERE TagId=@tag";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@tag", tag);
            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {                   
                    fname = Convert.ToString(reader["FirstName"]);
                    lname = Convert.ToString(reader["LastName"]);
                    email = Convert.ToString(reader["Email"]);
                    balance = Convert.ToDecimal(reader["Balance"]);
                    ticket = Convert.ToString(reader["TicketType"]);
                    status = Convert.ToString(reader["Status"]);

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connectionToDB.Close();
            }
        
            holder = "Person: " + fname + " " + lname + "  Balance: " + balance + " " +
                "  Ticket type: " + ticket + " " +
                "  Status: " + status;

            return holder;

        }
    }
}
