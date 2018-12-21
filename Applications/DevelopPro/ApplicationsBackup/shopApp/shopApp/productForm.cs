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

namespace shopApp
{
    public partial class productForm : Form
    {
        public bool ItemIsAdded;
        public decimal quantity;
        public string Pname { get; set; }
        public productForm(PictureBox pb, string name, decimal price)
        {
            InitializeComponent();
            picShow.Image = pb.Image;
            Pname = lbName.Text = name;
            lbPrice.Text = price.ToString("$0.00");
            ItemIsAdded = false;
        }

        private void btnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ItemIsAdded = true;
            quantity = pbQuantity.Value;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
