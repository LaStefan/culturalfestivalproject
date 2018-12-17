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

namespace LoanApp
{
    public partial class PersonalDetails : Form
    {
        private Customer cust;
        public PersonalDetails(Customer c)
        {
            InitializeComponent();
            cust = c;
        }

        private void PersonalDetails_Load(object sender, EventArgs e)
        {
            lbName.Text = cust.FirstName;
            lbLastName.Text = cust.LastName;
            ticketType.Text = cust.TicketType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
