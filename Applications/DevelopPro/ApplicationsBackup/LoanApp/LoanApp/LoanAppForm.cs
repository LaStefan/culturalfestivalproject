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
            panelReturn.Visible = false;
            panelInventory.Visible = false;
            panelItem.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            panelItem.Visible = false;
            panelLoan.Visible = false;
            panelReturn.Visible = false;
            panelInventory.Visible = false;
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnLoan.Height;
            sideBar.Top = btnLoan.Top;
            panelLoan.Visible = true;
            panelReturn.Visible = false;
            panelInventory.Visible = false;
            panelLoan.Dock = DockStyle.Fill;
            productDataGV.Rows.Clear();
            foreach (Product p in listOfProducts)
            {
                productDataGV.Rows.Add(p.LoanId.ToString(), p.LoanName, DateTime.Now, "5", p.Deposit.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbPhone_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Mobile Phone");
            listOfProducts.Add(product);
            LoanForm lf = new LoanForm(product);
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
            listOfProducts.Add(product);
            LoanForm lf = new LoanForm(product);
            lf.Show();
        }

        private void pbFlashlight_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Touch Light");
            product.produtList.Add(product);
            LoanForm lf = new LoanForm(product);
            lf.Show();
        }

        private void pbBags_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Mattress");
            listOfProducts.Add(product);
            LoanForm lf = new LoanForm(product);
            lf.Show();
        }

        private void pbCamera_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Camera");
            listOfProducts.Add(product);
            LoanForm lf = new LoanForm(product);
            lf.Show();
        }

        private void pbBlanckets_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Blanket");
            listOfProducts.Add(product);
            LoanForm lf = new LoanForm(product);
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
            
        }

        private void TagAdd(object sender, RFIDTagEventArgs e)
        {
            chipNr = e.Tag;
            Customer temp = product.GetCustomer(chipNr);
            PersonalDetails pd = new PersonalDetails(temp);
            pd.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            product.LoanItem(listOfProducts, chipNr);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnReturn.Height;
            sideBar.Top = btnReturn.Top;
            panelLoan.Visible = false;
            panelReturn.Visible = true;
            panelInventory.Visible = false;
            panelReturn.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sideBar.Height = button2.Height;
            sideBar.Top = button2.Top;
            panelLoan.Visible = false;
            panelReturn.Visible = false;
            panelInventory.Visible = true;
            panelInventory.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelReturn_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            productDataGV.Rows.Clear();
            listOfProducts.Clear();
            productDataGV.Refresh();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productDataGV.SelectedRows)
            {
                productDataGV.Rows.RemoveAt(row.Index);
                int productId = (int)productDataGV.Rows[row.Index].Cells[0].Value;
                var product = listOfProducts.FirstOrDefault(p => p.LoanId == productId);
                if (product != null)
                    listOfProducts.Remove(product);
                productDataGV.Refresh();
            }
        }
    }
}
