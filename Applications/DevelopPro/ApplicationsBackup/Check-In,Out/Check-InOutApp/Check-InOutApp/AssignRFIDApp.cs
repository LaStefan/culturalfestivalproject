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
using Phidget22;
using Phidget22.Events;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Check_InOutApp
{
    public partial class AssignRFIDApp : Form
    {
        private MySqlConnection conn;
        private RFID myRFIDReader;
        Database myData;
        public AssignRFIDApp()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
            lbShow.BackColor = Color.DimGray;
            myData = new Database();
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                  "database=dbi401148;" +
                                   "user id=dbi401148;" +
                                   "password=123456789;";
            conn = new MySqlConnection(connectionInfo);
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.TagLost += MyRFIDReader_TagLost;
                myRFIDReader.Tag += MyRFIDReader_Tag;
                
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not startup!");
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
      

        private void MyRFIDReader_Tag(object sender, RFIDTagEventArgs e)
        {
            try
            {
                
                int id = Convert.ToInt32(tbTicketNr.Text);
                bool checkId = myData.CheckCustomer(id);
                bool checkTag = myData.CheckIfAssigned(e.Tag);
                
                if (checkId)
                { if (checkTag != true)

                    {
                        string sql = "UPDATE customer SET TagId = @tag WHERE CustomerId = @id";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@tag", e.Tag);


                        int update;
                        conn.Open();
                        update = command.ExecuteNonQuery();


                        lbShow.Items.Clear();
                        //MessageBox.Show("This person has a ticket!");
                        lbShow.BackColor = Color.Green;
                        lbShow.Items.Add("Valid ticket!");
                        
                        lbShow.Items.Add(e.Tag);
                    }
                    else
                    {
                        lbShow.Items.Clear();
                        lbShow.BackColor = Color.Yellow;
                        lbShow.Items.Add("Bracelet already assigned!");
                    }
                }
                else
                {
                    lbShow.Items.Clear();
                    lbShow.BackColor = Color.Red;
                    lbShow.Items.Add("Ticket not valid!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                conn.Close();
            }
            tbTicketNr.Clear();
            tbTicketNr.Focus();
        }

        private void MyRFIDReader_TagLost(object sender, RFIDTagLostEventArgs e)
        {

            //lbShow.Items.Clear();
            //lbShow.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = button1.Text;

            try
            {
                if (s == "Power/ON")
                {
                    myRFIDReader.Open();
                    tbTicketNr.Enabled = true;
                    lbShow.Enabled = true;
                    lbShow.BackColor = Color.White;
                    this.BackColor = Color.White;
                    button1.Text = "Power/OFF";
                }
                else
                {
                    myRFIDReader.Close();
                    tbTicketNr.Enabled = false;
                    lbShow.Enabled = false;
                    this.BackColor = Color.LightGray;
                    lbShow.BackColor = Color.DimGray;
                    button1.Text = "Power/ON";
                }
                
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Could not connect to the RFID-Reader!");
            }



        }

        private void rbCheckIn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AssignRFIDApp_Load(object sender, EventArgs e)
        {

        }
    }
}
