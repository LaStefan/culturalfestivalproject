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
using Phidget22.Events;
using Phidget22;


namespace EventStatusApp
{
    public partial class EventStatusForm : Form
    {
        private RFID myRFIDReader;
        Database myData = new Database();
        public EventStatusForm()
        {
            InitializeComponent();
            try
            {
                myRFIDReader = new RFID();
                //myRFIDReader.TagLost += MyRFIDReader_TagLost;
               // myRFIDReader.Tag += MyRFIDReader_Tag;

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not startup!");
            }
        }

        private void btnTotalVisitors_Click(object sender, EventArgs e)
        {
            int nr=myData.GetVisitorNumber();
            lbOverview.Items.Add(nr.ToString());
        }

        private void btnCurrentStatus_Click(object sender, EventArgs e)
        {
            myRFIDReader.Open();
            String person = myData.GetInfo(Convert.ToString(myRFIDReader.GetLastTag()));
            lbOverview.Items.Add(person);
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {

        }
    }
}
