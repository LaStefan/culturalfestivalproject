using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevelopPro;
using Phidget22;
using Phidget22.Events;
using MySql.Data.MySqlClient;
using MySql.Data;




namespace shopApp
{
    public partial class ShopAppForm : Form
    {
        private MySqlConnection conn;
        private RFID myRFIDReader;
        Database myData;
        productForm pq;
       Product myProduct;
        List<Product> products;
        List<Customer> customers;
        decimal totalPrice=0;
        
        public ShopAppForm()
        {
            InitializeComponent();
            myData = new Database();
            
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                  "database=dbi401148;" +
                                   "user id=dbi401148;" +
                                   "password=123456789;";
            conn = new MySqlConnection(connectionInfo);
            try
            {
                myRFIDReader = new RFID();
                //myRFIDReader.TagLost += MyRFIDReader_TagLost;
                myRFIDReader.Tag += MyRFIDReader_Tag;
                
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not startup!");
            }
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            panelDrinks.Visible = false;
            panelFood.Visible = false;
            panelPay.Visible = false;
            products = GetProducts();
            customers = myData.GetCustomers();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        /// <summary>
        /// This function is a helper function to pass selected item information to productForm
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public void ShowProductForm(PictureBox pb, string name, decimal price)
        {
            pq = new productForm(pb, name, price);
            //??????????
            pq.FormClosed += new FormClosedEventHandler(productForm_FormClosed);
            pq.ShowDialog();
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            panelFood.Visible = false;
            panelDrinks.Visible = false;
            panelPay.Visible = false;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnFood.Height;
            sideBar.Top = btnFood.Top;
            panelDrinks.Visible = false;
            panelPay.Visible = false;
            panelFood.Visible = true;
            panelFood.Dock = DockStyle.Fill;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnDrinks.Height;
            sideBar.Top = btnDrinks.Top;
            panelFood.Visible = true;
            panelPay.Visible = false;
            panelDrinks.Visible = true;
            panelDrinks.Dock = DockStyle.Fill;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnPay.Height;
            sideBar.Top = btnPay.Top;
            panelFood.Visible = true;
            panelDrinks.Visible = true;
            panelPay.Visible = true;
            panelPay.Dock = DockStyle.Fill;
        }

       

        private void picHam_Click(object sender, EventArgs e)
        {
           foreach(Product p in products)
            {
                if(p.ProductName=="Burger")
                {
                    ShowProductForm(picHam, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBalls_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Meat Balls")
                {
                    ShowProductForm(picBalls, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }
        private void picWaffle_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Waffles")
                {
                    ShowProductForm(picWaffle, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }
        private void picSalad_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Salad")
                {
                    ShowProductForm(picSalad, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picFrite_Click_1(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Friet")
                {
                    ShowProductForm(picFrite, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picRice_Click(object sender, EventArgs e)
        {
            foreach(Product p in products)
            {
                if (p.ProductName == "Rice")
                {
                    ShowProductForm(picRice, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
           
        }

        private void picPizza_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Pizza")
                {
                    ShowProductForm(picPizza, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picFruit_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Fruit")
                {
                    ShowProductForm(picFruit, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void panelFood_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void picKaas_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Kaas")
                {
                    ShowProductForm(picKaas, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picPancakes_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Pancakes")
                {
                    ShowProductForm(picPancakes, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picKremen_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Kremen")
                {
                    ShowProductForm(picKremen, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
           
        }

        private void picWings_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Chicken Wings")
                {
                    ShowProductForm(picWings, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
           
        }

        private void picDurum_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Durum")
                {
                    ShowProductForm(picDurum, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picLamb_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Lamb")
                {
                    ShowProductForm(picLamb, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Apple Juice")
                {
                    ShowProductForm(picApple, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Orange Juice")
                {
                    ShowProductForm(picOrange, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picBeer_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Beer")
                {
                    ShowProductForm(picBeer, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picRadler_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Radler")
                {
                    ShowProductForm(picRadler, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
           
        }

        private void picTea_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Tea")
                {
                    ShowProductForm(picTea, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picWhiskey_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Whisky")
                {
                    ShowProductForm(picWhiskey, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picRedWine_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Red Wine")
                {
                    ShowProductForm(picRedWine, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picRedBull_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "RedBull")
                {
                    ShowProductForm(picRedBull, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picFanta_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Fanta")
                {
                    ShowProductForm(picFanta, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picWater_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Water")
                {
                    ShowProductForm(picWater, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
           
        }

        private void picKoffiee_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Koffie")
                {
                    ShowProductForm(picKoffiee, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void picCola_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "CocaCola")
                {
                    ShowProductForm(picCola, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
           
        }

        private void picSprite_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Sprite")
                {
                    ShowProductForm(picSprite, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
           
        }

        private void picCoctail_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Coctail")
                {
                    ShowProductForm(picCoctail, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
            
        }

        private void productDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //rfid tag reader
        private void MyRFIDReader_Tag(object sender, RFIDTagEventArgs e)
        {
            foreach(Customer c in customers)
            {
                if(c.TagId==e.Tag)
                {
                    if(c.Balance>=totalPrice)
                    {
                        //change balance and stock
                        myData.ChangeBalance(e.Tag, totalPrice, c.Balance);
                        c.Balance -= totalPrice;
                        MessageBox.Show("Thank you for the purchase." +
                            "Come again!");
                    }
                    else
                    {
                        MessageBox.Show("Not enough money for this purchase!");
                    }
                }
            }
            
        }
        public void productForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pq.ItemIsAdded)
            {     
                
                    //  MessageBox.Show("Just got a bite ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productDataGV.Rows.Add(myProduct.ProductName, myProduct.Stock.ToString(), myProduct.ProductPrice.ToString(), pq.quantity);
                decimal price = myProduct.ProductPrice * pq.quantity;


               // myProduct.Stock =Convert.ToInt32( myProduct.Stock - pq.quantity);
                totalPrice += price;
            }       
                
            //?????????
           pq.FormClosed -= new FormClosedEventHandler(productForm_FormClosed);
        }
        public List<Product> GetProducts()
        {
            List<Product> temp = new List<Product>();

            int id;
            string name;
            decimal price;
            int stock;
            string sql = "SELECT ProductId,ProductName,Price,Stock FROM product";
            MySqlCommand command = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
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
                conn.Close();
            }

            return temp;
        }

        private void picWhiteWine_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "White Wine")
                {
                    ShowProductForm(picWhiteWine, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
        }

        private void picFish_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                if (p.ProductName == "Fish")
                {
                    ShowProductForm(picFish, p.ProductName, p.ProductPrice);
                    myProduct = p;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            productDataGV.Rows.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(productDataGV.CurrentRow.Selected)
            {

                productDataGV.Rows.RemoveAt(productDataGV.CurrentRow.Index);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            { myRFIDReader.Open();
                textBox1.Text = Convert.ToString(totalPrice);
                lbRfidCode.Text = "Please scan your bracelet for successfull purchase!";
                productDataGV.Enabled = false;
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not startup!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Close();
                textBox1.Clear();
                productDataGV.Enabled = true;
                lbRfidCode.Text = "";
                totalPrice = 0;
                productDataGV.Rows.Clear();

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not startup!");
            }
        }
    }
}
