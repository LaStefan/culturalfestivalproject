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

namespace EventStatusApp
{
    public partial class EventStatusForm : Form
    {
        Database myData = new Database();
        public EventStatusForm()
        {
            InitializeComponent();
        }

        private void btnTotalVisitors_Click(object sender, EventArgs e)
        {
            int nr=myData.GetVisitorNumber();
            lbOverview.Items.Add(nr.ToString());
        }
    }
}
