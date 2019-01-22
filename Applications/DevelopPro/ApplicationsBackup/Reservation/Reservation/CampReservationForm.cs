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
        Dictionary<int, Customer> customerDic;
        List<CheckBox> checkBoxes;
        public string tagId;
        int count = 1;

        public CampReservationForm()
        {
            InitializeComponent();
            campingSites = new List<CampingSite>();
            dbConnect = new DatabaseConnector();
            
            customerDic = new Dictionary<int, Customer>();
            campingSites =dbConnect.GetAllCampingSites();
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

            checkBoxes = new List<CheckBox>();

            checkBoxes.Add(ckNight1);
            checkBoxes.Add(ckNight2);
            checkBoxes.Add(ckNight3);

            try
            {
                RFID reader = new RFID();
                reader.Tag += Reader_Tag;
                reader.TagLost += Reader_TagLost;
                reader.Open();
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

        private Customer GetFirstCustomer()
        {
            foreach(KeyValuePair<int, Customer> d in customerDic)
            {
                if (d.Key == 1)
                    return d.Value;
            }
            return null;
        }

        private List<Customer> GetRestCustomers()
        {
            List<Customer> customers = new List<Customer>();
            foreach(KeyValuePair<int, Customer> d in customerDic)
            {
                if(d.Key > 1)
                {
                    customers.Add(d.Value);                   
                }
                
            }
            return customers;
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
            
            Customer customer = dbConnect.GetInfo(e.Tag);                     
            lbshowCus.Items.Add("Name: "+ customer.Fname+" "+customer.Lname);
            lbshowCus.Items.Add("Balance: " + customer.Balance);
            lbshowCus.Items.Add("Ticket Type: " + customer.TicketType);
            lbshowCus.Items.Add("Status: " + customer.Status);
            lbshowCus.Items.Add("CampingSite Id: " + customer.CampId);
            lbshowCus.Items.Add("");
            tagId = customer.TagId;
            customerDic.Add(count, customer);
            count++;
        }

        private void Reader_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            
        }

        private bool CheckForm(Form form)
        {
            form = Application.OpenForms[form.Text];
            if (form != null)
                return true;
            else
                return false;
        }

        private string GetDate()
        {
            string date;

            if (ckNight1.Checked)
            {
                date = ckNight1.Text;
                return date;
            }
            else if (ckNight2.Checked)
            {
                date = ckNight2.Text;
                return date;
            }
            else if (ckNight3.Checked)
            {
                date = ckNight3.Text;
                return date;
            }
            else
                return null;
        }     

        private void btnPay_Click_1(object sender, EventArgs e)
        {
               
            foreach (RadioButton b in rbuttons)
            {
                if (b.Checked)
                {
                    int id = GetIdbyRb(b);
                    CampingSite c = GetCampingById(id);
                    if (dbConnect.GetInfo(tagId) != null)
                    {
                        if (dbConnect.CheckCustomerCamp(tagId) == false)
                        {
                            if (dbConnect.CheckStatus(id) == false)
                            {
                                if (GetDate() != null)
                                {
                                    if (UpdateBalance() >= 0)
                                    {                                      
                                        Customer firstCustomer = GetFirstCustomer();
                                        List<Customer> temp = GetRestCustomers();
                                        dbConnect.ReserveCamp(id, GetDate());
                                        dbConnect.UpdateCampIdAndBalanceByTagId(id, firstCustomer.TagId, UpdateBalance());
                                        foreach (Customer cus in temp)
                                        {
                                            dbConnect.UpdateCampIdByTagId(id, cus.TagId);
                                        }
                                        b.BackColor = Color.Red;
                                        lbShow.Items.Add("You have successfully registered Campingsite " + c.CampingId);
                                        lbShow.Items.Add("Camping maximum for " + c.CampingType);
                                        lbShow.Items.Add(GetDate());                                      
                                    }
                                    else
                                    {
                                        lbShow.Items.Add("Wrong! You do not have enough balance!");
                                    }
                                }
                                else
                                {
                                    lbShow.Items.Add("Please select a correct date!");
                                }
                            }
                            else
                            {
                                lbShow.Items.Add("Sorry, this Campingsite is not valid!");
                            }
                        }
                        else
                        {
                            lbShow.Items.Add("Wrong! The reservation failed!");
                            lbShow.Items.Add("You have already reserved a campingsite!");
                        }
                    }
                    else
                    {
                        lbShow.Items.Add("Please scan RFID first!");
                    }
                }
            }
        }       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
        }

        private decimal UpdateBalance()
        {       
            int id = 0;
            foreach (RadioButton b in rbuttons)
            {
                if (b.Checked)
                {
                    id = GetIdbyRb(b);
                }
            }
            Customer c = GetFirstCustomer();
            //decimal balance = dbConnect.GetBalanceByTag(tagId);
            decimal balance = c.Balance;
            int price = dbConnect.GetPriceByCampId(id);

            decimal balance2 = balance - Convert.ToDecimal(price);

            return balance2;
        }

        private void btClear2_Click(object sender, EventArgs e)
        {
            lbshowCus.Items.Clear();
            customerDic.Clear();
        }
    }
}
