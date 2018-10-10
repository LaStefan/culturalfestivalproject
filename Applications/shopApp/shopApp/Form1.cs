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
            panelDrinks.Visible = false;
            panelFood.Visible = false;
            panelPay.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            panelFood.Visible = false;
            panelDrinks.Visible = false;
            panelPay.Visible = false;
            
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnFood.Height;
            sideBar.Top = btnFood.Top;
            panelDrinks.Visible = false;
            panelPay.Visible = false;
            panelFood.Visible = true;
           
            panelFood.Dock = DockStyle.Fill;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnDrinks.Height;
            sideBar.Top = btnDrinks.Top;
            panelFood.Visible = true;
            panelPay.Visible = false;
            panelDrinks.Visible = true;
            panelDrinks.Dock = DockStyle.Fill;
            
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnPay.Height;
            sideBar.Top = btnPay.Top;
            panelFood.Visible = true;
            panelDrinks.Visible = true;
            panelPay.Visible = true;
            panelPay.Dock = DockStyle.Fill;
            
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
