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
using Phidget22.Events;
using Phidget22;

namespace LoanApp
{
    public partial class LoanAppForm : Form
    {
        private Product product = new Product(0, "", 0, 0);
        private RFID rfid = new RFID();
        private List<Product> listOfProducts = new List<Product>();
        string chipNr = "";
        public LoanAppForm()
        {
            InitializeComponent();
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            rfid.Open();
            rfid.Tag += TagAdd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnBrowse.Height;
            sideBar.Top = btnBrowse.Top;
            panelItem.Visible = true;
            panelLoan.Visible = false;
            panelItem.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            panelItem.Visible = false;
            panelLoan.Visible = false;
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnLoan.Height;
            sideBar.Top = btnLoan.Top;
            panelLoan.Visible = true;
            panelLoan.Dock = DockStyle.Fill;
            productDataGV.Rows.Clear();
            foreach (Product p in listOfProducts)
            {
                productDataGV.Rows.Add(p.LoanId.ToString(), p.LoanName, DateTime.Now, "5", p.Deposit.ToString());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbPhone_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Mobile Phone");
            LoanForm lf = new LoanForm(product);
            listOfProducts.Add(product);
            lf.Show();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {

        }

        private void lbRFID_Click(object sender, EventArgs e)
        {

        }

        private void pbUSB_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("charger");
            LoanForm lf = new LoanForm(product);
            listOfProducts.Add(product);
            lf.Show();
        }

        private void pbFlashlight_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Touch Light");
            LoanForm lf = new LoanForm(product);
            listOfProducts.Add(product);
            lf.Show();
        }

        private void pbBags_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Mattress");
            LoanForm lf = new LoanForm(product);
            listOfProducts.Add(product);
            lf.Show();
        }

        private void pbCamera_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Camera");
            LoanForm lf = new LoanForm(product);
            listOfProducts.Add(product);
            lf.Show();
        }

        private void pbBlanckets_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Blanket");
            LoanForm lf = new LoanForm(product);
            listOfProducts.Add(product);
            lf.Show();
        }

        private void productDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Customer temp = product.GetCustomer(chipNr);
            PersonalDetails pd = new PersonalDetails(temp);
            pd.Show();
        }

        private void TagAdd(object sender, RFIDTagEventArgs e)
        {
            chipNr = e.Tag;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            product.LoanItem(listOfProducts, chipNr);
        }
    }
}
