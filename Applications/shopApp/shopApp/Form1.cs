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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            panelFood.Visible = false;
            panelDrinks.Visible = false;
            panelPayment.Visible = false;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnFood.Height;
            sideBar.Top = btnFood.Top;
            panelFood.Visible = true;
            panelDrinks.Visible = false;
            panelPayment.Visible = false;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnDrinks.Height;
            sideBar.Top = btnDrinks.Top;
            panelFood.Visible = false;
            panelDrinks.Visible = true;
            panelPayment.Visible = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnPay.Height;
            sideBar.Top = btnPay.Top;
            panelDrinks.Visible = false;
            panelPayment.Visible = true;
            panelFood.Visible = false;
           
        }
    }
}
