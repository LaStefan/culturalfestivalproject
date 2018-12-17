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
        public MySqlConnection Conn { get; set; }
        
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
            String sql = "SELECT COUNT(*) FROM customer";
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
        public bool CheckCustomer(int id)
        {
            String sql = "SELECT CustomerId FROM customer";
            MySqlCommand command = new MySqlCommand(sql, conn);
            List<int> temp = new List<int>();
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int custid = Convert.ToInt32(reader[0]);
                    temp.Add(custid);
                }
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            foreach(int i in temp)
            { 
                if(i==id)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckedInOrNot(String tag)
        {
            String sql = "SELECT Status FROM customer WHERE TagId=@tag";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@tag", tag);
            List<String> temp = new List<String>();
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string str = Convert.ToString(reader["Status"]);
                    temp.Add(str);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            foreach(String s in temp)
            {
                if(s=="Checked")
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckIfAssigned(string tagId)
        {
            String sql = "SELECT TagId FROM customer";
            MySqlCommand command = new MySqlCommand(sql, conn);
            List<String> temp = new List<String>();
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tag = Convert.ToString(reader["TagId"]);
                    temp.Add(tag);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            foreach(String s in temp)
            {
                if(s==tagId)
                {
                    return true;
                }
            }
            return false;

        }
       public string GetInfo(string tag)
        {
            string holder;
            String fname="";
            String lname="";
            String email="";
            decimal balance=0;
            String ticket="";
            String status="";
            String sql = "SELECT FirstName, LastName,Email,Balance,TicketType,Status FROM customer WHERE CustomerId=@tag";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@tag", tag);
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                
                while(reader.Read())
                {
                    fname = Convert.ToString(reader["FirstName"]);
                     lname = Convert.ToString(reader["LastName"]);
                     email = Convert.ToString(reader["Email"]);
                     balance = Convert.ToDecimal(reader["Balance"]);
                     ticket = Convert.ToString(reader["TicketType"]);
                    status = Convert.ToString(reader["Status"]);

                }

            }catch(MySqlException ex)
            {
                MessageBox.Show(sqlExceptionMessage(ex.ToString()));
            }
            finally
            {
                conn.Close();
            }
            holder = "Person: " + fname + " " + lname + "\nBalance: " + balance + 
                "$\nEmail: " + email + 
                "\nTicket type: " + ticket +
                "\nStatus: " + status;
            
            return holder;
            
        }
        public int GetID(int id)
        {
            String sql = "SELECT CustomerId FROM customer";
            MySqlCommand command = new MySqlCommand(sql, conn);
            List<int> temp = new List<int>();
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int custid = Convert.ToInt32(reader[0]);
                    temp.Add(custid);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            foreach(int i in temp)
            {
                if(i==id)
                {
                    return id;
                }
            }
            return 0;
        }

      
    }
}
