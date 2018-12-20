using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CampCheckInOut
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

        public bool CheckCustomerCamp(string tag)
        {

            String sql = "SELECT CampingSiteId FROM customer WHERE TagId=@tag";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@tag", tag);
            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Convert.ToString(reader["CampingSiteId"]) != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

            return false;

        }

        public int CheckCustomerCampStatus(string tag)
        {
            int status = 0;
            String sql = "SELECT CampingSiteStatus FROM customer WHERE TagId=@tag";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@tag", tag);
            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    status = Convert.ToInt32(reader["CampingSiteStatus"]);            
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

            return status;

        }

        public void UpdateCampStatus(string tagId, int status)
        {           
            string sql = "UPDATE customer SET CampingSiteStatus=@campStatus WHERE TagId=@tagId";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@campStatus", status);
            command.Parameters.AddWithValue("@tagId", tagId);
            try
            {
                int update;
                connectionToDB.Open();
                update = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connectionToDB.Close();
            }
        }

        public string GetInfo(string tag)
        {
            string holder = "";
            String fname = "";
            String lname = "";
            String email = "";
            decimal balance = 0;
            String ticket = "";
            String status = "";
            String campId = "";
            String sql = "SELECT CustomerId, FirstName, LastName,Email,Balance,TicketType,Status, CampingSiteId FROM customer WHERE TagId=@tag";
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
                    campId = Convert.ToString(reader["CampingSiteId"]);
                    holder = "Person: " + fname + " " + lname + "  Balance: " + balance + " " +
                "  Ticket type: " + ticket + " " +
                "  Status: " + status + ", CampingSiteId:" + campId;
                    return holder;
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



            return holder;

        }

        public int GetCampingSiteId(string tag)
        {
            int campingSiteId = 0;

            String sql = "SELECT CampingSiteId FROM customer WHERE TagId=@tag";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@tag", tag);
            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    campingSiteId = Convert.ToInt32(reader["CampingSiteId"]);
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

            return campingSiteId;
        }

        public void CheckoutCamp(int campId)
        {
            string sql = "UPDATE campingsite SET Status=@campStatus, Date=@date WHERE CampingSiteId=@campId";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@campStatus", 0);
            command.Parameters.AddWithValue("@campId", campId);
            command.Parameters.AddWithValue("@date", "");
            try
            {
                int update;
                connectionToDB.Open();
                update = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connectionToDB.Close();
            }
        }

        public void UpdateCampId(string tagId)
        {
            string sql = "UPDATE customer SET CampingSiteId=NULL WHERE TagId=@tagId";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@tagId", tagId);
            try
            {
                int update;
                connectionToDB.Open();
                update = command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connectionToDB.Close();
            }
        }

    }
}
