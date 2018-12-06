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
using MySql.Data;
using MySql.Data.MySqlClient;
using DevelopPro;
namespace Reservation
{
    public partial class CampReservationForm : Form
    {
        DatabaseConnector dbConnect;
        List<CampingSite> campingSites;
        List<RadioButton> rbuttons;
        Dictionary<int, RadioButton> dic;
        //private bool reservationCheck = false;

        public CampReservationForm()
        {
            InitializeComponent();
            campingSites = new List<CampingSite>();
            dbConnect = new DatabaseConnector();
        
            campingSites =dbConnect.GetAllCampingSites();
          
            //lbShow.Items.Add(campingSites.Count);
            rbuttons = new List<RadioButton>();

            rbuttons.Add(rb1);
            rbuttons.Add(rb2);
            rbuttons.Add(rb3);
            rbuttons.Add(rb4);
            rbuttons.Add(rb5);
            rbuttons.Add(rb6);
            rbuttons.Add(rb7);
            rbuttons.Add(rb8);
            rbuttons.Add(rb9);
            rbuttons.Add(rb10);
            rbuttons.Add(rb11);
            rbuttons.Add(rb12);

            dic = new Dictionary<int, RadioButton>();

            dic.Add(1, rb1);
            dic.Add(2, rb2);
            dic.Add(3, rb3);
            dic.Add(4, rb4);
            dic.Add(5, rb5);
            dic.Add(6, rb6);
            dic.Add(7, rb7);
            dic.Add(8, rb8);
            dic.Add(9, rb9);
            dic.Add(10, rb10);
            dic.Add(11, rb11);
            dic.Add(12, rb12);

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

            Setup();
        }

        private void Setup()
        {
            foreach (CampingSite c in campingSites)
            {
                if (c.Status =="1")
                {
                    RadioButton b = GetRadioButtonById(c.CampingId);
                    b.BackColor = Color.Red;
                }
            }
        }

        private RadioButton GetRadioButtonById(int id)
        {
            foreach (KeyValuePair<int, RadioButton> d in dic)
            {
                if (d.Key == id)
                    return d.Value;
            }
            return null;
        }

        private int GetIdbyRb(RadioButton b)
        {
            foreach (KeyValuePair<int, RadioButton> d in dic)
            {
                if (d.Value == b)
                    return d.Key;
            }
            return 0;
        }

        private CampingSite GetCampingById(int id)
        {
            foreach (CampingSite c in campingSites)
            {
                if (c.CampingId == id)
                {
                    return c;
                }
            }
            return null;
        }

        private void Reader_Tag(object sender, RFIDTagEventArgs e)
        {
            string c = dbConnect.GetInfo(e.Tag);
            textBox1.Text = c;
           
        }

        private void Reader_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            //if (reservationCheck)
            //{
            //    lbShow.Items.Add("Thanks for your reservation!");
            //}
            //else
            //{
            //    lbShow.Items.Add("Reservation cancelled!");
            //}
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            string stDate = dateTimePicker1.Value.Year+"-"+dateTimePicker1.Value.Month+"-"+dateTimePicker1.Value.Day;
            string enDate = dateTimePicker2.Value.Year+"-"+dateTimePicker2.Value.Month+"-"+dateTimePicker2.Value.Day;
            foreach (RadioButton b in rbuttons)
            {
                if (b.Checked)
                {
                    int id = GetIdbyRb(b);
                    CampingSite c = GetCampingById(id);
                    if (dbConnect.CheckStatus(id) == false)
                    {                     
                        dbConnect.ReserveCamp(id,stDate,enDate);                      
                        b.BackColor = Color.Red;
                        lbShow.Items.Add("You have successfully registered Campingsite " + c.CampingId);
                        lbShow.Items.Add("Camping maximum for " + c.CampingType);
                        lbShow.Items.Add("Start from " + stDate);
                        lbShow.Items.Add("To " + enDate);
                    }
                    else
                    {
                        lbShow.Items.Add("Sorry, this Campingsite has already registered!");
                    }
                }
            }
        }    
    }
}
