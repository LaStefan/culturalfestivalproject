using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopPro
{
    public partial class LoginForm : Form
    {
        CheckInOutForm checkInOutForm;
        public LoginForm()
        {
            InitializeComponent();
            checkInOutForm = new CheckInOutForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkInOutForm.Show();
        }
    }
}
