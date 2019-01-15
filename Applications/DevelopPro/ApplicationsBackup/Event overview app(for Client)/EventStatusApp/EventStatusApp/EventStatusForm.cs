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

            labels.Add(lb2);
            labels.Add(lb6);
            labels.Add(lb10);
            labels.Add(lb13);
            labels.Add(lb3);
            labels.Add(lb7);
            labels.Add(lb4);
            labels.Add(lb9);
            labels.Add(lb11);
            labels.Add(lb5);
            labels.Add(lb8);
            labels.Add(lb12);

            dic = new Dictionary<int, Label>();

            dic.Add(1, lb2);
            dic.Add(2, lb3);
            dic.Add(3, lb4);
            dic.Add(4, lb5);
            dic.Add(5, lb6);
            dic.Add(6, lb7);
            dic.Add(7, lb8);
            dic.Add(8, lb9);
            dic.Add(9, lb10);
            dic.Add(10, lb11);
            dic.Add(11, lb12);
            dic.Add(12, lb13);

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
            decimal MoneyPerShop = myData.MoneyGainedPerShop();
            decimal MoneyPerLoan = myData.MoneyGainedPerLoan();
            decimal MoneyForTickets = myData.MoneyGainedForTickets();
            decimal TOTAL = MoneyForTickets + MoneyPerLoan + MoneyPerShop;
            int nr = myData.GetVisitorNumber();
            decimal balance = myData.GetTotalBalance();
            int nrinside = myData.GetVisitorNumberInsideEvent();
            lbOverview.Show();
            pbMap.Hide();
            HideLables();
             lbOverview.Items.Clear();
            lbOverview.Items.Add(DateTime.Now);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("Total money earned so far: $" + TOTAL);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("Total balance of all visitors: $" + balance);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("Total number of customers: " + nr.ToString());
            lbOverview.Items.Add("checked in: " + nrinside.ToString());


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
            decimal MoneyForTickets = myData.MoneyGainedForTickets();
            decimal TOTAL = MoneyForTickets + MoneyPerLoan + MoneyPerShop;
           
            lbOverview.Show();
            pbMap.Hide();
            HideLables();
            lbOverview.Items.Clear();
            lbOverview.Items.Add(DateTime.Now);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("Total amount earned in shop: $" + MoneyPerShop);
            lbOverview.Items.Add("Total amount earned in loan shop: $" + MoneyPerLoan);
            lbOverview.Items.Add("Total amount earned for the tickets: $" + MoneyForTickets);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("TOTAL: $" + TOTAL);


        }
    }
}
