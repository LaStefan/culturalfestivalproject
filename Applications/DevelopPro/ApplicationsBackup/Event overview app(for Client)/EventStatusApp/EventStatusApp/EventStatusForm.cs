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
using Reservation;
using Phidget22.Events;
using Phidget22;


namespace EventStatusApp
{
    public partial class EventStatusForm : Form
    {
        private RFID myRFIDReader;
        Database myData = new Database();
        Dictionary<int, Label> dic;
        List<Label> labels;

        public EventStatusForm()
        {
            InitializeComponent();
            pbMap.Hide();
            
            labels = new List<Label>();

            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);

            dic = new Dictionary<int, Label>();

            dic.Add(1, label2);
            dic.Add(2, label3);
            dic.Add(3, label4);
            dic.Add(4, label5);
            dic.Add(5, label6);
            dic.Add(6, label7);
            dic.Add(7, label8);
            dic.Add(8, label9);
            dic.Add(9, label10);
            dic.Add(10, label11);
            dic.Add(11, label12);
            dic.Add(12, label13);

            HideLables();
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
            pbMap.Hide();
            HideLables();
            lbOverview.Show();
            int nr=myData.GetVisitorNumber();
            int nrinside = myData.GetVisitorNumberInsideEvent();
            lbOverview.Items.Clear();
            lbOverview.Items.Add(DateTime.Now);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("Total number of customers: "+nr.ToString());
            lbOverview.Items.Add("currently checked in: " + nrinside.ToString());
        }

        private void btnCurrentStatus_Click(object sender, EventArgs e)
        {
          
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            pbMap.Hide();
            HideLables();
            lbOverview.Show();
            decimal balance = myData.GetTotalBalance();
            lbOverview.Items.Clear();
            lbOverview.Items.Add(DateTime.Now);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("Total balance of all visitors: $" + balance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCamp_Click(object sender, EventArgs e)
        {
            ShowLables();        
            pbMap.Show();
            lbOverview.Hide();
            DatabaseConnector databaseConnector = new DatabaseConnector();
            List<CampingSite> temp = databaseConnector.GetAllCampingSites();
            foreach (CampingSite c in temp)
            {
                if (c.Status == "1")
                {
                    Label l = GetLableById(c.CampingId);
                    l.BackColor = Color.Red;
                }
            }
        }

        private Label GetLableById(int id)
        {
            foreach (KeyValuePair<int, Label> d in dic)
            {
                if (d.Key == id)
                    return d.Value;
            }
            return null;
        }
        private void HideLables()
        {
            foreach(Label l in labels)
            {
                l.Hide();
            }
        }
        private void ShowLables()
        {
            foreach(Label l in labels)
            {
                l.Show();
            }
        }

        private void btnMoneySpent_Click(object sender, EventArgs e)
        {
            decimal MoneyPerShop = myData.MoneyGainedPerShop();
            decimal MoneyPerLoan = myData.MoneyGainedPerLoan();
            lbOverview.Show();
            pbMap.Hide();
            HideLables();
            lbOverview.Items.Clear();
            lbOverview.Items.Add(DateTime.Now);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("Total amount earned in shop: $" + MoneyPerShop);
            lbOverview.Items.Add("Total amount earned in loan shop: $" + MoneyPerLoan);

        }
    }
}
