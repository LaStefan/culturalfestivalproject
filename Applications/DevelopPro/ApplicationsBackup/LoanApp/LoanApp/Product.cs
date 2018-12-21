using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopPro;
using Phidget22;
using Phidget22.Events;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace LoanApp
{
    public class Product
    {
        private int loanId;
        private string loanName;
        private decimal deposit;
        private int stock;
        private int quantity;
        private DateTime startDate;
        private MySqlConnection conn;
        public List<Product> produtList = new List<Product>();
        private Customer cust;

        public int LoanId { get { return this.loanId; } }
        public string LoanName { get { return this.loanName; } }
        public decimal Deposit { get { return this.deposit; } }
        public int Stock { get { return this.stock; } }
        public int Quantity { get { return this.quantity; } }
        public DateTime StartDate { get { return this.startDate; } }

        public Product(int LoanId, string LoanName, decimal Deposit, int Stock)
        {
            this.loanId = LoanId;
            this.loanName = LoanName;
            this.deposit = Deposit;
            this.stock = Stock;
        }

        public Product(int LoanId, string LoanName, decimal Deposit, int Quantity, DateTime StartDate)
        {
            this.loanId = LoanId;
            this.loanName = LoanName;
            this.deposit = Deposit;
            this.quantity = Quantity;
            this.startDate = StartDate;
        }

        public override string ToString()
        {
            return (this.loanId + " " + this.loanName + " " + this.deposit).ToString();
        }

        private void Database()
        {
            String connectionInfo = "server=studmysql01.fhict.local; " +
                                   "database=dbi401148;" +
                                    "user id=dbi401148;" +
                                    "password=123456789;";
            conn = new MySqlConnection(connectionInfo);
        }

        public Product GetProduct(string product)
        {
            Product temp = null;
            try
            {
                Database();
                conn.Open();
                string select = "SELECT * FROM loan WHERE ProductName = '" + product + "'";
                MySqlCommand msc = new MySqlCommand(select, conn);

                MySqlDataReader mdr = msc.ExecuteReader();

                if (mdr.Read())
                {
                    this.loanId = mdr.GetInt32("loanId");
                    this.loanName = mdr.GetString("ProductName");
                    this.deposit = mdr.GetDecimal("Deposit");
                    this.stock = mdr.GetInt32("Stock");
                    temp = new Product(loanId, loanName, deposit, stock);
                    return temp;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception) { }
            finally
            {
                conn.Close();
            }
            return temp;
        }

        public void AddToList(Product prod)
        {
            this.produtList.Add(prod);
        }

        public Customer GetCustomer(string rfid)
        {
            Database();
            conn.Open();
            Customer temp = null;
            string sql = "SELECT * FROM customer WHERE TagId = '" + rfid + "'";
            MySqlCommand msc = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = msc.ExecuteReader();
            if(mdr.Read())
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

        public int FindCustomerId(string rfid)
        {
            Database();
            conn.Open();
            int temp = 0;
            string sql = "SELECT CustomerId FROM customer WHERE TagId = '" + rfid +"'";
            MySqlCommand mysqlcommand = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = mysqlcommand.ExecuteReader();
            if (mdr.Read())
            {
                temp = mdr.GetInt32("customerId");
            }
            mdr.Close();
            return temp;
        }

        public void LoanItem(List<Product> listOfProd, string rfid)
        {
            int temp = FindCustomerId(rfid);
            foreach(Product p in listOfProd)
            {
                string sql = "INSERT INTO `loanitem`(`LoanItemId`, `BorrowDate`, `ReturnDate`, `StateReturned`, `CustomerId`, `LoanId`) " +
                    "VALUES (null,sysdate(),null,null," + temp +" ," + p.LoanId + ")";
                MySqlCommand msc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msc.ExecuteReader();
                mdr.Close();
                string sql2 = "SELECT Balance from customer where TagId = '" + rfid + "'";
                MySqlCommand msc2 = new MySqlCommand(sql2, conn);
                MySqlDataReader mdr2 = msc2.ExecuteReader();
                if (mdr2.Read())
                {
                    decimal balance = mdr2.GetDecimal("Balance");
                    if (balance >= p.deposit)
                    {
                        mdr2.Close();
                        string updateBalance = "UPDATE `customer` SET `Balance`= Balance - '" +  p.deposit + "' WHERE TagId = '" + rfid + "'";
                        MySqlCommand msc3 = new MySqlCommand(updateBalance, conn);
                        MySqlDataReader mdr3 = msc3.ExecuteReader();
                        mdr3.Close();
                        string sql1 = "UPDATE `loan` SET `Stock`= Stock - 1 WHERE LoanId = " + p.LoanId + "";
                        MySqlCommand msc1 = new MySqlCommand(sql1, conn);
                        MySqlDataReader mdr1 = msc1.ExecuteReader();
                        mdr1.Close();
                        System.Windows.Forms.MessageBox.Show("The item was successfully borrowed!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Not enough balance!");
                    }
                }
            }
        }

        public List<Product> GetBorrowedProducts(string rfid)
        {
            try
            {
                Database();
                conn.Open();
                List<Product> listOfBorrowed = new List<Product>();
                string sql = "SELECT lo.* FROM loanitem l JOIN customer c ON(l.CustomerId = c.CustomerId)" +
                    " JOIN loan lo ON(l.LoanId = lo.LoanId) WHERE c.TagId = '" + rfid + "'";
                MySqlCommand msc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msc.ExecuteReader();
                while (mdr.Read())
                {
                    int id = mdr.GetInt32("LoanId");
                    string prodName = mdr.GetString("ProductName");
                    decimal deposit =  mdr.GetDecimal("Deposit");
                    int stock = mdr.GetInt32("Stock");
                    Product temp = new Product(id, prodName, deposit, stock);
                    listOfBorrowed.Add(temp);
                }
                return listOfBorrowed;
            }
            catch(MySqlException )
            {
                System.Windows.Forms.MessageBox.Show("Something went wrong!");
            }
            finally { conn.Close(); }
            return null;
        }

        public void RefundBorrowedItem(Product p, string rfid)
        {
            try
            {
                Database();
                conn.Open();
                string sql = "UPDATE `loan` SET `Stock`= Stock + 1 WHERE LoanId = '" + p.loanId + "';";
                MySqlCommand msc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msc.ExecuteReader();
                mdr.Close();
                string sql1 = "UPDATE `customer` SET `Balance`= Balance + '" +  p.deposit + "' WHERE TagId = '" + rfid + "';";
                MySqlCommand msc1 = new MySqlCommand(sql1, conn);
                MySqlDataReader mdr1 = msc1.ExecuteReader();
                mdr1.Close();
                int customerId = FindCustomerId(rfid);
                string sql2 = "DELETE FROM `loanitem` WHERE CustomerId = " + customerId + " AND LoanId = " + p.loanId + ";";
                MySqlCommand msc2 = new MySqlCommand(sql2, conn);
                MySqlDataReader mdr2 = msc2.ExecuteReader();
                mdr2.Close();
            }
            catch(MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
       
    }
}
