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

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not startup!");
            }
        }

        private void MyRFIDReader_Tag(object sender, RFIDTagEventArgs e)
        {
            try
            {
                String statusIn = "Checked";
                String statusOut = "Not checked";
                bool checkedin = myData.CheckedInOrNot(e.Tag);
                bool checkTag = myData.CheckIfAssigned(e.Tag);
                if (rbCheckin.Checked)
                {
                    if (checkTag == true)
                    {
                        if (checkedin != true)
                        {
                            string sql = "UPDATE customer SET Status=@stat WHERE TagId = @id";
                            MySqlCommand command = new MySqlCommand(sql, conn);
                            command.Parameters.AddWithValue("@id", e.Tag);
                            command.Parameters.AddWithValue("@stat", statusIn);


                            int update;
                            conn.Open();
                            update = command.ExecuteNonQuery();

                            lbShow.Items.Clear();
                            //MessageBox.Show("This person has a ticket!");
                            lbShow.BackColor = Color.Green;
                            lbShow.Items.Add("Checked IN");
                            lbShow.Items.Add(e.Tag);
                        }

                        else
                        {
                            MessageBox.Show("Already checked in..");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bracelet is not assigned to a person...");
                    }
                   
                }
                else
                {
                    if (checkTag == true)
                    {
                        if (checkedin == true)
                        {
                            string sql = "UPDATE customer SET Status=@stat WHERE TagId = @id";
                            MySqlCommand command = new MySqlCommand(sql, conn);
                            command.Parameters.AddWithValue("@id", e.Tag);
                            command.Parameters.AddWithValue("@stat", statusOut);


                            int update;
                            conn.Open();
                            update = command.ExecuteNonQuery();

                            lbShow.Items.Clear();
                            //MessageBox.Show("This person has a ticket!");
                            lbShow.BackColor = Color.White;
                            lbShow.Items.Add("Checked OUT");
                            lbShow.Items.Add(e.Tag);
                        }
                        else
                        {
                            MessageBox.Show("Already checked out..");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bracelet is not assigned to a person...");
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
            try
            {
                myRFIDReader.Open();
               
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not connect to the RFID-Reader!");
            }
        }
    }
}
