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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
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

        }

        private void btnADD_Click(object sender, EventArgs e)
        {

        }

        private void lbRFID_Click(object sender, EventArgs e)
        {

        }
    }
}
