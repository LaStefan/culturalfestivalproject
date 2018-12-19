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
using MySql.Data.MySqlClient;
using MySql.Data;
namespace CheckInOutCamping
{
    public partial class CheckInOutApp : Form
    {
        private MySqlConnection conn;
        private RFID myRFIDReader;
        Database myData;
        
        List<Customer> customers;
        public CheckInOutApp()
        {
            InitializeComponent();
            
            myData = new Database();
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                  "database=dbi401148;" +
                                   "user id=dbi401148;" +
                                   "password=123456789;";
            conn = new MySqlConnection(connectionInfo);
            try
            {
                myRFIDReader = new RFID();
                //myRFIDReader.TagLost += MyRFIDReader_TagLost;
                myRFIDReader.Tag += MyRFIDReader_Tag;
                   myRFIDReader.Open();
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not startup!");
            }
            customers = myData.GetCustomers();
        }

        private void MyRFIDReader_Tag(object sender, RFIDTagEventArgs e)
        {
            try
            {
               // String statusIn = "Checked";
                //String statusOut = "Not checked";
                bool checkedin = myData.CheckedInOrNot(e.Tag);
                bool checkTag = myData.CheckIfAssigned(e.Tag);
                if (rbCheckin.Checked)
                {
                    if (checkTag == true)
                    {
                        if (checkedin != true)
                        {
                            myData.CheckIn(e.Tag);
                            
                           
                            lbShow.Items.Clear();
                            //MessageBox.Show("This person has a ticket!");
                            lbShow.BackColor = Color.Green;
                            lbShow.Items.Add("Checked IN");
                            //lbShow.Items.Add(e.Tag);
                            //getting firstname and last name of the customer for the output
                            foreach (Customer c in customers)
                            {
                                if (c.TagId == e.Tag)
                                {
                                    lbShow.Items.Add("Welcome to our event " + c.FirstName);
                                    lbShow.Items.Add("Have lots of fun!");
                                }
                            }
                        }

                        else
                        {   foreach(Customer c in customers)
                            {
                                if(c.TagId==e.Tag)
                                {
                                    lbShow.Items.Clear();
                                    lbShow.BackColor = Color.White;
                                    lbShow.Items.Add(c.FirstName + " " + c.LastName + " is already checked in!");
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        lbShow.Items.Clear();
                        lbShow.BackColor = Color.White;
                        lbShow.Items.Add("Bracelet is not assigned to a person...");
                    }
                   
                }
                else
                {
                    if (checkTag == true)
                    {
                        if (checkedin == true)
                        {
                            myData.CheckOut(e.Tag);

                            lbShow.Items.Clear();
                            //MessageBox.Show("This person has a ticket!");
                            lbShow.BackColor = Color.Red;
                            lbShow.Items.Add("Checked OUT");
                            lbShow.Items.Add("Thank you for visiting us, see you soon!");
                            //lbShow.Items.Add(e.Tag);
                        }
                        else
                        {
                            lbShow.Items.Clear();
                            lbShow.BackColor = Color.White;
                            lbShow.Items.Add("Already checked out..");
                        }
                    }
                    else
                    {
                        lbShow.Items.Clear();
                        lbShow.BackColor = Color.White;
                        lbShow.Items.Add("Bracelet is not assigned to a person...");
                    }
                }
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }


        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenRfid_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    myRFIDReader.Open();
               
            //}
            //catch (PhidgetException)
            //{
            //    MessageBox.Show("Could not connect to the RFID-Reader!");
           // }
        }
       
    }
}
