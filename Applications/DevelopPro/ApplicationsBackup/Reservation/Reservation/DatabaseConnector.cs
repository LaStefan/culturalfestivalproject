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

        public void ReserveCamp(int campId , string date)
        {
            string sql = "UPDATE campingsite SET Date=@date, Status=1 WHERE CampingSiteId=@campId";
           
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@date", date);
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

        public Customer GetInfo(string tag)
        {           
            String fname = "";
            String lname = "";
            String email = "";
            decimal balance = 0;
            String ticket = "";
            String status = "";
            String campId = "";
            String tagId = "";
            String sql = "SELECT CustomerId, FirstName, LastName,Email,Balance,TicketType,Status, CampingSiteId, TagId FROM customer WHERE TagId=@tag";
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
                    tagId = Convert.ToString(reader["TagId"]);
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
            Customer customer = new Customer(fname, lname, balance, ticket, status, campId, tagId);
            

            return customer;

        }

        public int GetCustomerId(string tag)
        {
            int customerId = 0;

            String sql = "SELECT CustomerId FROM customer WHERE TagId=@tag";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@tag", tag);
            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    customerId = Convert.ToInt32(reader["CustomerId"]);                
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

            return customerId;
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
                    if(Convert.ToString(reader["CampingSiteId"]) != "")
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

        public void UpdateCampIdAndBalanceByTagId(int campId, string tagId, decimal balance)
        {
            string sql = "UPDATE customer SET CampingSiteId=@campId, Balance=@balance WHERE TagId=@tagId";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@campId", campId);
            command.Parameters.AddWithValue("@tagId", tagId);
            command.Parameters.AddWithValue("@balance", balance);
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

        public void UpdateCampIdByTagId(int campId, string tagId)
        {
            string sql = "UPDATE customer SET CampingSiteId=@campId WHERE TagId=@tagId";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@campId", campId);
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

        public decimal GetBalanceByTag(string tagId)
        {
            decimal balance = 0;

            String sql = "SELECT Balance FROM customer WHERE TagId=@tag";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@tag", tagId);
            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    balance = Convert.ToDecimal(reader["Balance"]);
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

            return balance;
        }

        public int GetPriceByCampId(int campId)
        {
            int price = 0;

            String sql = "SELECT Price FROM campingSite WHERE CampingSiteId=@campId";
            MySqlCommand command = new MySqlCommand(sql, connectionToDB);
            command.Parameters.AddWithValue("@campId", campId);
            try
            {
                connectionToDB.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    price = Convert.ToInt32(reader["Price"]);
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

            return price;
        }
    }
}
