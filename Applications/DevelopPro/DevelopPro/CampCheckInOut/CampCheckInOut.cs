using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace CampCheckInOut
{
    public partial class CampCheckInOut : Form
    {

        DatabaseConnector dbConnector;
        public CampCheckInOut()
        {
            InitializeComponent();
            dbConnector = new DatabaseConnector();

            try
            {
                RFID reader = new RFID();
                reader.Tag += Reader_Tag;
                reader.TagLost += Reader_TagLost;
                reader.Open(5000);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Reader_Tag(object sender, RFIDTagEventArgs e)
        {
            lbShow.Items.Clear();
            if (rbCheckin.Checked)
            {
                if (dbConnector.CheckCustomerCamp(e.Tag))
                {
                    if (dbConnector.CheckCustomerCampStatus(e.Tag) == 0)
                    {
                        dbConnector.UpdateCampStatus(e.Tag, 1);
                        int campId = dbConnector.GetCampingSiteId(e.Tag);
                        lbShow.BackColor = Color.Green;
                        lbShow.Items.Add("You have successfully Checked in Campingsite "+campId+" !");
                    }
                    else
                    {
                        lbShow.BackColor = Color.Red;
                        lbShow.Items.Add("Wrong, Your campingsite has already checked in!");
                    }
                }
                else
                {
                    lbShow.BackColor = Color.Red;
                    lbShow.Items.Add("Sorry, You do not reserve any campingsite yet!");
                }
            }
            if (rbCheckOut.Checked)
            {
                if (dbConnector.CheckCustomerCamp(e.Tag))
                {           
                    if (dbConnector.CheckCustomerCampStatus(e.Tag) == 1)
                    {
                        lbShow.BackColor = Color.Green;
                        dbConnector.CheckoutCamp(dbConnector.GetCampingSiteId(e.Tag));
                        dbConnector.UpdateCampStatus(e.Tag, 0);
                        dbConnector.UpdateCampId(e.Tag);
                        lbShow.Items.Add("Thanks, Campingsite has Checkout successfully!");
                    }
                    else
                    {
                        lbShow.BackColor = Color.Red;
                        lbShow.Items.Add("Sorry, this camping site do not check in yet!");
                    }
                }
                else
                {
                    lbShow.BackColor = Color.Red;
                    lbShow.Items.Add("Sorry, You do not reserve any campingsite yet!");
                }

            }
            
        }

        private void Reader_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
