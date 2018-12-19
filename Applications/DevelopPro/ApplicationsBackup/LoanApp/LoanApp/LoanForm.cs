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

            try { 
            if (this.prod.LoanName == "Mobile Phone")
            {
                picShow.Image = Image.FromFile("../Images/phone.png");
            }
                else if (this.prod.LoanName == "Camera")
                {
                    picShow.Image = Image.FromFile("../Images/camera.jpg");
                }
                else if (this.prod.LoanName == "Touch Light")
                {
                    picShow.Image = Image.FromFile("../Images/light.png");
                }
                else if (this.prod.LoanName == "Charger")
                {
                    picShow.Image = Image.FromFile("../Images/charger.png");
                }
                else if (this.prod.LoanName == "Blanket")
                {
                    picShow.Image = Image.FromFile("../Images/blanket.jpg");
                }
                else if (this.prod.LoanName == "Mattress")
                {
                    picShow.Image = Image.FromFile("../Images/mattress.jpg");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("There was an error. Please check the image path.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lbNrInStock.Text = prod.Stock.ToString();
            lbDeposit.Text = "€" + prod.Deposit.ToString();
            lbName.Text = prod.LoanName;
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
