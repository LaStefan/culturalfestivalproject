using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopPro;
using Phidget22;
using Phidget22.Events;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace shopApp
{
    class Shop
    {
        Database myData;
        List<Product> products;

       
        public Shop()
        {
            products = new List<Product>();
            myData = new Database();
        }

        public Database MyData
        {
            get { return myData; }
        }
        public Product GetProduct( string name)
        {
            foreach(Product p in GetProducts())
            {
                if(p.ProductName == name)
                {
                    return p;
                }
            }
            return null;
        }
        public List<Product> GetProducts()
        {
            List<Product> temp = new List<Product>();

            int id;
            string name;
            decimal price;
            int stock;
            string sql = "SELECT ProductId,ProductName,Price,Stock FROM product";

            try
            {
                myData = new Database();
                myData.Conn.Open();
                
                 MySqlCommand command = new MySqlCommand(sql, myData.Conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ProductId"]);
                    name = Convert.ToString(reader["ProductName"]);
                    price = Convert.ToDecimal(reader["Price"]);
                    stock = Convert.ToInt32(reader["Stock"]);
                    temp.Add(new Product(id, name, price, stock));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                myData.Conn.Close();
            }

            return temp;
        }
        public List<Customer> GetCustomers()
        {
            return myData.GetCustomers();
        }

    }
}
