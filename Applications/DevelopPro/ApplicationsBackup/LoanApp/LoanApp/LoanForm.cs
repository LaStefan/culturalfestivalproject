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
        public LoanForm(Product prod)
        {
            InitializeComponent();
            this.prod = prod;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 10000;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label4.Text = prod.Stock.ToString();
            lbPrice.Text = prod.Deposit.ToString();
            label2.Text = "Name: " + prod.LoanName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            prod.AddToList(prod);
            this.Close();
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
