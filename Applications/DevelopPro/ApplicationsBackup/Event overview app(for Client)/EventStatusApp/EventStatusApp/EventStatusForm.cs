﻿using System;
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
            int nrinside = myData.GetVisitorNumberInsideEvent();
            lbOverview.Items.Clear();
            lbOverview.Items.Add(DateTime.Now);
            lbOverview.Items.Add("");
            lbOverview.Items.Add("Total number of visitors: "+nr.ToString());
            lbOverview.Items.Add("currently inside the event: " + nrinside.ToString());
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

        private void btnBalance_Click(object sender, EventArgs e)
        {
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
            DatabaseConnector databaseConnector = new DatabaseConnector();
            List<CampingSite> temp = databaseConnector.GetAllCampingSites();
            lbOverview.Items.Clear();
            lbOverview.Items.Add("Free - 0, Booked - 1");
            foreach(CampingSite c in temp)
            {
                lbOverview.Items.Add("CampingSite Id: " + c.CampingId + ", Free or Not: " + c.Status);
            }
        }
    }
}
