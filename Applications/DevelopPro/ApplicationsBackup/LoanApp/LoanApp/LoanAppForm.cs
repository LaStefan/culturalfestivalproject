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
            panelItem.Show();
            panelLoan.Hide();
            panelReturn.Hide();
            panelInventory.Hide();
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
            panelLoan.Show();
            panelItem.Hide();
            panelReturn.Hide();
            panelInventory.Hide();
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
            LoanForm lf = new LoanForm(product, listOfProducts);
            lf.Show();
        }

        private void pbUSB_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Charger");
            LoanForm lf = new LoanForm(product, listOfProducts);
            lf.Show();
        }

        private void pbFlashlight_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Touch Light");
            LoanForm lf = new LoanForm(product, listOfProducts);
            lf.Show();
        }

        private void pbBags_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Mattress");
            LoanForm lf = new LoanForm(product, listOfProducts);
            lf.Show();
        }

        private void pbCamera_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Camera");
            LoanForm lf = new LoanForm(product, listOfProducts);
            lf.Show();
        }

        private void pbBlanckets_Click(object sender, EventArgs e)
        {
            product = product.GetProduct("Blanket");
            LoanForm lf = new LoanForm(product, listOfProducts);
            lf.Show();
        }

        private void TagAdd(object sender, RFIDTagEventArgs e)
        {
            chipNr = e.Tag;
            Customer temp = product.GetCustomer(chipNr);
            PersonalDetails pd = new PersonalDetails(temp);
            if (!CheckForm(pd))
            {
                pd.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            product.LoanItem(listOfProducts, chipNr);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnReturn.Height;
            sideBar.Top = btnReturn.Top;
            panelLoan.Hide();
            panelItem.Hide();
            panelReturn.Show();
            panelInventory.Hide();
            panelReturn.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sideBar.Height = button2.Height;
            sideBar.Top = button2.Top;
            panelLoan.Hide();
            panelItem.Hide();
            panelReturn.Hide();
            panelInventory.Show();
            panelInventory.Dock = DockStyle.Fill;
        }

        private bool CheckForm(Form form)
        {
            form = Application.OpenForms[form.Text];
            if (form != null)
                return true;
            else
                return false;
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
                //int productId = (int)productDataGV.Rows[row.Index].Cells[0].Value;
                var product = listOfProducts.FirstOrDefault();
                if (product != null)
                    listOfProducts.Remove(product);
                productDataGV.Refresh();
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            Product temp = (Product)listBox1.SelectedItem;
            product.RefundBorrowedItem(temp, chipNr);
            listBox1.Items.Clear();
            List<Product> lp = product.GetBorrowedProducts(chipNr);
            foreach (var item in lp)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Product> temp = product.GetBorrowedProducts(chipNr);
            foreach (var item in temp)
            {
                listBox1.Items.Add(item);
            }
        }

        private void panelLoan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
