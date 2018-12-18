using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shopApp.classes;



namespace shopApp
{
    public partial class ShopAppForm : Form
    {
        productForm pq;
        public Product currentItem;
        public ShopAppForm()
        {
            InitializeComponent();
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            panelDrinks.Visible = false;
            panelFood.Visible = false;
            panelPay.Visible = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void productForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pq.ItemIsAdded)
            {
              //  MessageBox.Show("Just got a bite ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                productDataGV.Rows.Add(currentItem.ID, currentItem.Name, currentItem.Quantity.ToString(), currentItem.Price.ToString());
            }
            pq.FormClosed -= new FormClosedEventHandler(productForm_FormClosed);
        }
        /// <summary>
        /// This function is a helper function to pass selected item information to productForm
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public void ShowProductForm(PictureBox pb, string name, double price)
        {
            pq = new productForm(pb, name, price);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picHam_Click(object sender, EventArgs e)
        {
            currentItem = new Product(1, "Hamburger", 2.50, 0, null);
            ShowProductForm(picHam, "Hamburger", 0.05);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBalls_Click(object sender, EventArgs e)
        {
            currentItem = new Product(2, "Balls", 2.50, 3, null);
            ShowProductForm(picBalls, "Balls", 2.50);
        }
        private void picWaffle_Click(object sender, EventArgs e)
        {
            currentItem = new Product(4, "Waffles", 2.50, 6, null);
            ShowProductForm(picWaffle, "Waffles", 2.50);
        }
        private void picSalad_Click(object sender, EventArgs e)
        {
            currentItem = new Product(5, "Salads", 3.50, 1, null);
            ShowProductForm(picSalad, "Salads", 3.50);
        }

        private void picFrite_Click_1(object sender, EventArgs e)
        {
            currentItem = new Product(3, "Frit", 2.00, 7, null);
            ShowProductForm(picFrite, "Frit", 2.00);
        }

        private void picRice_Click(object sender, EventArgs e)
        {
            currentItem = new Product(11, "Rice", 1.00, 1, null);
            ShowProductForm(picRice, "Rice", 1.00);
        }

        private void picPizza_Click(object sender, EventArgs e)
        {
            currentItem = new Product(8, "Pizza", 1.00, 0, null);
            ShowProductForm(picPizza, "Pizza", 1.00);
        }

        private void picFruit_Click(object sender, EventArgs e)
        {
            currentItem = new Product(10, "Fruit", 1.10, 1, null);
            ShowProductForm(picFruit, "Fruit", 1.10);
        }

        private void panelFood_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void picKaas_Click(object sender, EventArgs e)
        {
            currentItem = new Product(9, "kaas", 1.20, 5, null);
            ShowProductForm(picKaas, "Kaas", 1.20);
        }

        private void picPancakes_Click(object sender, EventArgs e)
        {
            currentItem = new Product(20, "Pancakes", 1.00, 2, null);
            ShowProductForm(picPancakes, "Pancakes", 1.00);
        }

        private void picKremen_Click(object sender, EventArgs e)
        {
            currentItem = new Product(16, "Kremen", 1.00, 2, null);
            ShowProductForm(picKremen, "Kremen", 1.00);
        }

        private void picWings_Click(object sender, EventArgs e)
        {
            currentItem = new Product(17, "Chicken Wings", 1.10, 1, null);
            ShowProductForm(picWings, "Chicken Wings", 1.10);
        }

        private void picDurum_Click(object sender, EventArgs e)
        {
            currentItem = new Product(15, "Durum", 1.30, 3, null);
            ShowProductForm(picDurum, "Durum", 1.30);
        }

        private void picLamb_Click(object sender, EventArgs e)
        {
            currentItem = new Product(13, "Lamb Meat", 1.10, 1, null);
            ShowProductForm(picLamb, "Lamb Meat", 1.10);
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            currentItem = new Product(21, "Apple juice", 0.10, 1, null);
            ShowProductForm(picApple, "Apple Juice", 0.10);
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            currentItem = new Product(22, "Orange juice", 0.20, 5, null);
            ShowProductForm(picOrange, "Orange Juice", 0.10);
        }

        private void picBeer_Click(object sender, EventArgs e)
        {
            currentItem = new Product(23, "Beer", 0.10, 1, null);
            ShowProductForm(picBeer, "Beer", 0.10);
        }

        private void picRadler_Click(object sender, EventArgs e)
        {
            currentItem = new Product(24, "Radler", 0.20, 5, null);
            ShowProductForm(picRadler, "Radler", 0.20);
        }

        private void picTea_Click(object sender, EventArgs e)
        {
            currentItem = new Product(25, "Tea", 0.05, 1, null);
            ShowProductForm(picTea, "Tea", 0.05);
        }

        private void picWhiskey_Click(object sender, EventArgs e)
        {
            currentItem = new Product(26, "Whiskey", 1.10, 1, null);
            ShowProductForm(picWhiskey, "Whiskey", 1.10);
        }

        private void picRedWine_Click(object sender, EventArgs e)
        {
            currentItem = new Product(27, "Red Wine", 1.10, 1, null);
            ShowProductForm(picRedWine, "Red Wine", 1.10);
        }

        private void picRedBull_Click(object sender, EventArgs e)
        {
            currentItem = new Product(29, "RedBull", 0.50, 6, null);
            ShowProductForm(picRedBull, "RedBull", 0.50);
        }

        private void picFanta_Click(object sender, EventArgs e)
        {
            currentItem = new Product(30, "Fanta", 0.20, 2, null);
            ShowProductForm(picFanta, "Fanta", 0.20);
        }

        private void picWater_Click(object sender, EventArgs e)
        {
            currentItem = new Product(28, "Water", 0.05, 1, null);
            ShowProductForm(picWater, "Water", 0.05);
        }

        private void picKoffiee_Click(object sender, EventArgs e)
        {
            currentItem = new Product(33, "Koffee", 0.10, 1, null);
            ShowProductForm(picKoffiee, "Koffee", 0.10);
        }

        private void picCola_Click(object sender, EventArgs e)
        {
            currentItem = new Product(34, "Cola", 0.50, 4, null);
            ShowProductForm(picCola, "Cola", 0.50);
        }

        private void picSprite_Click(object sender, EventArgs e)
        {
            currentItem = new Product(36, "Sprite", 0.50, 4, null);
            ShowProductForm(picSprite, "Sprite", 0.50);
        }

        private void picCoctail_Click(object sender, EventArgs e)
        {
            currentItem = new Product(35, "Coctail", 0.50, 4, null);
            ShowProductForm(picCoctail, "Coctail", 0.50);
        }

        private void productDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
