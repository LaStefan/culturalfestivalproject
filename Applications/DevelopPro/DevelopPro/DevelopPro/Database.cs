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
        //list of items used in the loan application
        public List<Item> listOfItems = new List<Item>();
        private Item item = null;
       
        //create database connection
        private MySqlConnection conn;
        public Database()
        {
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                   "database=dbi401148;" +
                                    "user id=dbi401148;" +
                                    "password=123456789;";
            conn = new MySqlConnection(connectionInfo);
        }

           public MySqlConnection Conn { get { return conn; } }
        private string sqlExceptionMessage(string originalExceptionMessage)
        {
            return (
                "For regular users: Database problem detected" +
                "\n\n" +
                "For developers: " + originalExceptionMessage
                );
        }

        public int GetVisitorNumber()
        {
            int nr = 0;
            String sql = "SELECT COUNT(*) FROM customer";
            MySqlCommand command = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();

                nr = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(sqlExceptionMessage(ex.ToString()));
            }
            finally
            {
                conn.Close();
            }
            return nr;
        }
        public int GetVisitorNumberInsideEvent()
        {
            int nr = 0;
            List<Customer> temp = GetCustomers();
            foreach(Customer c in temp)
            {
                if(c.Status=="Checked")
                {
                    nr++;
                }
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
            foreach (int i in temp)
            {
                if (i == id)
                {
                    return true;
                }
            }
            return false;
        }
        public void ChangeStock(int stock)
        {
            try
            {
                string sql = "UPDATE product SET Stock=@stock";
                MySqlCommand command = new MySqlCommand(sql, conn);
                //command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@stock", stock);


                int update;
                conn.Open();
                update = command.ExecuteNonQuery();
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }

            
        }
       
        public decimal MoneyGainedForTickets()
        {
            decimal Total = 0;
            decimal oneday = 59;
            decimal twoday = 109;
            decimal threeday = 159;
            String sql = "SELECT TicketType FROM customer";
            List<String> ticket = new List<String>();
            MySqlCommand command = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tickets = Convert.ToString(reader["TicketType"]);
                    ticket.Add(tickets);

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
            foreach(String s in ticket)
            {
                if(s=="One Day Ticket"||s=="one day ticket")
                {
                    Total += oneday;
                }
                else if(s=="Two Day Ticket"|| s=="two days ticket")
                {
                    Total += twoday;
                }
                else
                {
                    Total += threeday;
                }
            }
            return Total;
        }
        public decimal MoneyGainedPerLoan()
        {
            decimal Total = 0;
            String sql = "SELECT ChargedMoney FROM loanitem";
            MySqlCommand command = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    decimal money = Convert.ToDecimal(reader["ChargedMoney"]);
                    Total += money;

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
            return Total;
        }
        public decimal MoneyGainedPerShop()
        {
            decimal Total = 0;
            String sql = "SELECT TotalPrice FROM orderstore";
            MySqlCommand command = new MySqlCommand(sql, conn);
            
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    decimal money = Convert.ToDecimal(reader["TotalPrice"]);
                    Total += money;
                    
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
            return Total;
        }
        public void RegisterAmountPayedInShop(decimal totalPrice,int id)
        {
            
            try
            {
                string sql = "INSERT INTO orderstore(TotalPrice,CustomeId) VALUES(@totalPrice,@id)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@totalPrice", totalPrice);


                int update;
                conn.Open();
                update = command.ExecuteNonQuery();
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool CheckIfItemIsBorrowed(int id)
        { 
            String sql = "SELECT ReturnDate FROM loanitem WHERE CustomerId=@customer";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@customer", id);
            List<String> temp = new List<String>();
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    String t= Convert.ToString(reader["ReturnDate"]);
                    temp.Add(t);
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
            foreach (String s in temp)
            {
                if (s==null || s==""||s=="NULL"||s=="null")
                {
                    return true;
                }
            }
            return false;
        }
        public int GetIdWithTag(String tag)
        { int Id=0;
            String sql = "SELECT CustomerId FROM customer WHERE TagId=@tag";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@tag", tag);
            
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["CustomerId"]);
                    Id = id;
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
            return Id;
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
            foreach (String s in temp)
            {
                if (s == "Checked")
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
            foreach (String s in temp)
            {
                if (s == tagId)
                {
                    return true;
                }
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
            String sql = "SELECT FirstName, LastName,Email,Balance,TicketType,Status FROM customer WHERE CustomerId=@tag";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@tag", tag);
            try
            {
                conn.Open();
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
            foreach (int i in temp)
            {
                if (i == id)
                {
                    return id;
                }
            }
            return 0;
        }

        public void CheckIn(string tag)
        {
            try
            {
                String statusIn = "Checked";
                string sql = "UPDATE customer SET Status=@stat WHERE TagId = @id";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", tag);
                command.Parameters.AddWithValue("@stat", statusIn);


                int update;
                conn.Open();
                update = command.ExecuteNonQuery();
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void CheckOut(string tag)
        {
            try
            {
                String statusOut = "Not checked";
                string sql = "UPDATE customer SET Status=@stat WHERE TagId = @id";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", tag);
                command.Parameters.AddWithValue("@stat", statusOut);


                int update;
                conn.Open();
                update = command.ExecuteNonQuery();

            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }
        }

       public List<Customer> GetCustomers()
        {
            List<Customer> temp = new List<Customer>();

            int id;
            string firstName;
            string lastName;
            decimal balance;
            string ticketType;
            string status;
            string tagId;
            string sql = "SELECT CustomerId,FirstName,LastName,Status,TicketType,Balance,TagId FROM customer";
            MySqlCommand command = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["CustomerId"]);
                    firstName = Convert.ToString(reader["FirstName"]);
                    lastName = Convert.ToString(reader["LastName"]);
                    balance = Convert.ToDecimal(reader["Balance"]);
                    status = Convert.ToString(reader["Status"]);
                    ticketType = Convert.ToString(reader["TicketType"]);
                    tagId = Convert.ToString(reader["TagId"]);

                    temp.Add(new Customer(id, firstName, lastName, balance, ticketType, status, tagId));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return temp;
        }

        public void ChangeBalance(string tag, decimal price,decimal balance)
        {
            try
            {
                string sql = "UPDATE customer SET Balance=@balance WHERE TagId = @id";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", tag);
                command.Parameters.AddWithValue("@balance", balance-price);


                int update;
                conn.Open();
                update = command.ExecuteNonQuery();
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public decimal GetTotalBalance()
        {
            decimal balance = 0;
            decimal totalbal = 0;
            String sql = "SELECT Balance FROM customer";
            MySqlCommand command = new MySqlCommand(sql, conn);
           
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   
                    balance = Convert.ToDecimal(reader["Balance"]);
                    totalbal += balance;

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(sqlExceptionMessage(ex.ToString()));
            }
            finally
            {
                conn.Close();
            }
            return totalbal;
        }
       

        //sql used for the loan application
        public Item GetProduct(string product)
        {
            try
            {
                conn.Open();
                string select = "SELECT * FROM loan WHERE ProductName = '" + product + "'";
                MySqlCommand msc = new MySqlCommand(select, conn);

                MySqlDataReader mdr = msc.ExecuteReader();

                if (mdr.Read())
                {
                    int loanId = mdr.GetInt32("loanId");
                    string loanName = mdr.GetString("ProductName");
                    decimal deposit = mdr.GetDecimal("Deposit");
                    int stock = mdr.GetInt32("Stock");
                    item = new Item(loanId, loanName, deposit, stock);
                    return new Item(loanId, loanName, deposit, stock);
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public Customer GetCustomer(string rfid)
        {
            try
            {
                conn.Open();
                Customer temp = null;
                string sql = "SELECT * FROM customer WHERE TagId = '" + rfid + "'";
                MySqlCommand msc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msc.ExecuteReader();
                if (mdr.Read())
                {
                    int id = mdr.GetInt32("CustomerId");
                    string name = mdr.GetString("FirstName");
                    string lname = mdr.GetString("LastName");
                    string email = mdr.GetString("Email");
                    string pass = mdr.GetString("Password");
                    decimal balance = mdr.GetDecimal("Balance");
                    string ticketType = mdr.GetString("TicketType");
                    string status = mdr.GetString("Status");
                    string tag = mdr.GetString("TagId");
                    temp = new Customer(id, name, lname, balance, ticketType, status, tag);
                }
                return temp;
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public int FindCustomerId(string rfid)
        {
            try
            {
                conn.Open();
                int temp = 0;
                string sql = "SELECT CustomerId FROM customer WHERE TagId = '" + rfid + "'";
                MySqlCommand mysqlcommand = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = mysqlcommand.ExecuteReader();
                while (mdr.Read())
                {
                    temp = mdr.GetInt32("customerId");
                }
                //mdr.Close();
                return temp;
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public void LoanItem(List<Item> listOfProd, string rfid, ref bool randomname)
        {
            decimal total = 0;
            bool sent = false;
            try
            {
                int temp = FindCustomerId(rfid);

                foreach (Item p in listOfProd)
                {
                    conn.Open();
                    string sqll = "SELECT COUNT(*) as total from loanitem where CustomerId = " + temp + " and LoanId = " + p.LoanId + " AND ReturnDate IS NULL";
                    MySqlCommand mdr = new MySqlCommand(sqll, conn);
                    MySqlDataReader md = mdr.ExecuteReader();
                    if (md.Read())
                    {
                        int reslt = md.GetInt32("total");
                        conn.Close();
                        if (reslt >= 1)
                        {
                            MessageBox.Show("Sorry " + p.LoanName + " is already borrowed!");
                        }
                        else
                        {
                            string sql2 = "SELECT Balance from customer where TagId = '" + rfid + "'";
                            MySqlCommand msc2 = new MySqlCommand(sql2, conn);
                            conn.Open();
                            MySqlDataReader mdr2 = msc2.ExecuteReader();

                            if (mdr2.Read())
                            {
                                decimal balance = mdr2.GetDecimal("Balance");
                                mdr2.Close();
                                foreach (Item item in listOfItems)
                                {
                                    total += item.Deposit;
                                }
                                if (balance >= total)
                                {
                                    string updateBalance = "UPDATE `customer` SET `Balance`= Balance - '" + p.Deposit + "' WHERE TagId = '" + rfid + "'";
                                    MySqlCommand msc3 = new MySqlCommand(updateBalance, conn);


                                    int result = msc3.ExecuteNonQuery();
                                    conn.Close();
                                    string sql1 = "UPDATE `loan` SET `Stock`= Stock - 1 WHERE LoanId = " + p.LoanId + "";
                                    MySqlCommand msc1 = new MySqlCommand(sql1, conn);
                                    conn.Open();

                                    int resultschanged = msc1.ExecuteNonQuery();
                                    conn.Close();
                                    randomname = true;
                                    conn.Open();
                                    string sql = "INSERT INTO `loanitem`(`LoanItemId`, `BorrowDate`, `ReturnDate`, `StateReturned`, `CustomerId`, `LoanId`) " +
                                "VALUES (null,sysdate(),null,null," + temp + " ," + p.LoanId + ")";
                                    MySqlCommand msc = new MySqlCommand(sql, conn);
                                    int res = msc.ExecuteNonQuery();
                                    conn.Close();
                                }
                                else
                                {
                                    if (sent == false)
                                    {
                                        MessageBox.Show("The customer does not have enough balance!");
                                    }
                                }
                                sent = true;
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Item> GetBorrowedProducts(string rfid)
        {
            try
            {
                conn.Open();
                List<Item> listOfBorrowed = new List<Item>();
                string sql = "SELECT lo.* FROM loanitem l JOIN customer c ON(l.CustomerId = c.CustomerId)" +
                    " JOIN loan lo ON(l.LoanId = lo.LoanId) WHERE c.TagId = '" + rfid + "' AND l.ReturnDate IS NULL";
                MySqlCommand msc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msc.ExecuteReader();
                while (mdr.Read())
                {
                    int id = mdr.GetInt32("LoanId");
                    string prodName = mdr.GetString("ProductName");
                    decimal deposit = mdr.GetDecimal("Deposit");
                    int stock = mdr.GetInt32("Stock");
                    Item temp = new Item(id, prodName, deposit, stock);
                    listOfBorrowed.Add(temp);
                }
                return listOfBorrowed;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Something went wrong!");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        
        public void RefundBorrowedItem(Item p, string rfid, string description, bool damaged)
        {
            try
            {
                Customer c = GetCustomer(rfid);
                conn.Open();
                string sql = "UPDATE `loan` SET `Stock`= Stock + 1 WHERE LoanId = '" + p.LoanId + "';";
                MySqlCommand msc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msc.ExecuteReader();
                mdr.Close();
                if (damaged == false)
                {
                    decimal tempmoney = p.Deposit * (decimal)0.25;
                    p.Deposit *= (decimal)0.75;
                    string sql1 = "UPDATE `customer` SET `Balance`= Balance + '" + p.Deposit + "' WHERE TagId = '" + rfid + "';";
                    MySqlCommand msc1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader mdr1 = msc1.ExecuteReader();
                    mdr1.Close();
                    
                    string sqll2 = "UPDATE `loanitem`" +
                        " SET `ReturnDate`=sysdate(),`StateReturned`= 'Good condition', ChargedMoney = " + tempmoney  + " WHERE CustomerId = " + c.Id + " AND LoanId = " + p.LoanId + ";";
                    MySqlCommand msccc1 = new MySqlCommand(sqll2, conn);
                    msccc1.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    string sql2 = "UPDATE `loanitem`" +
                        " SET `ReturnDate`=sysdate(),`StateReturned`= '" + description + "', ChargedMoney = " + p.Deposit + " WHERE CustomerId = " + c.Id + " AND LoanId = " + p.LoanId + ";";
                    MySqlCommand msc2 = new MySqlCommand(sql2, conn);
                    MySqlDataReader mdr2 = msc2.ExecuteReader();
                    mdr2.Close();
                }
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddInventory(Item p, int numericValue)
        {
            try
            {
                conn.Open();
                string updateStock = "UPDATE `loan` SET `Stock`= Stock + '" + numericValue + "' WHERE LoanId = '" + item.LoanId + "';";
                MySqlCommand msc = new MySqlCommand(updateStock, conn);
                MySqlDataReader mdr = msc.ExecuteReader();
                mdr.Close();
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (NullReferenceException s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        //here finish the code used for the loan application
    }
}
