using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanApp
{
    public partial class LoanForm : Form
    {
        private Product prod;
        private List<Product> lP = new List<Product>();
        public LoanForm(Product prod, List<Product> lp)
        {
            InitializeComponent();
            this.prod = prod;
            this.lP = lp;
            //if(this.prod.LoanName == "Mobile Phone")
            //{
            //    picShow.Image = Image.FromFile("");
            //}
            //else if(this.prod.LoanName == "Camera")
            //{
            //    picShow.Image = Image.FromFile("");
            //}
            //else if(this.prod.LoanName == "Flashing")
            //{

            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lbNrInStock.Text = prod.Stock.ToString();
            lbDeposit.Text = prod.Deposit.ToString();
            label2.Text = "Name: " + prod.LoanName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            lP.Add(prod);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
