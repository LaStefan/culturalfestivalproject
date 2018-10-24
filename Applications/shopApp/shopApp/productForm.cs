using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopApp
{
    public partial class productForm : Form
    {
        public bool ItemIsAdded;
        public productForm(PictureBox pb, string name, double price)
        {
            InitializeComponent();
            picShow.Image = pb.Image;
            lbName.Text = name;
            lbPrice.Text = price.ToString();
            ItemIsAdded = false;
        }

        private void btnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ItemIsAdded = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
