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
using DevelopPro;

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
        private DevelopPro.Database dbConn = new DevelopPro.Database();
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
            Database();
            conn.Open();
            string select = "SELECT * FROM loan WHERE ProductName = '" + product + "'";
            MySqlCommand msc = new MySqlCommand(select, conn);
            
            MySqlDataReader mdr = msc.ExecuteReader();

            if(mdr.Read())
            {
                this.loanId = mdr.GetInt32("loanId");
                this.loanName = mdr.GetString("ProductName");
                this.deposit = mdr.GetDecimal("Deposit");
                this.stock = mdr.GetInt32("Stock");
                Product temp = new Product(loanId, loanName, deposit, stock);
                return temp;
            }
            else
            {
                return null;
            }
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
                string sql1 = "UPDATE `loan` SET `Stock`= Stock - 1 WHERE LoanId = " + p.LoanId + "";
                MySqlCommand msc1 = new MySqlCommand(sql1, conn);
                MySqlDataReader mdr1 = msc1.ExecuteReader();
                mdr1.Close();
            }
            System.Windows.Forms.MessageBox.Show("Done");
        }
    }
}
