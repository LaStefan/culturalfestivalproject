using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DevelopPro
{
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\ApplicationsBackup\LoanApp\LoanApp\bin\Debug\LoanApp.exe");
            //this.Close();
            //DevelopPro\ApplicationsBackup\LoanApp\LoanApp\
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\ApplicationsBackup\shopApp\shopApp\bin\Debug\shopApp.exe");
        }

        private void log_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\ApplicationsBackup\ATM\ATM\bin\Debug\ATM.exe");
        }

        private void eventStatus_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\ApplicationsBackup\Event overview app(for Client)\EventStatusApp\EventStatusApp\bin\Debug\EventStatusApp.exe");
        }

        private void campingReserve_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\ApplicationsBackup\Reservation\Reservation\bin\Debug\Reservation.exe");
        }

        private void campingInOut_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\DevelopPro\CampCheckInOut\bin\Debug\CampCheckInOut.exe");
        }

        private void checkInOut_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\ApplicationsBackup\Check-In,Out Camping\CheckInOutCamping\CheckInOutCamping\bin\Debug\CheckInOutCamping.exe");
        }

        private void assignRFID_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\ApplicationsBackup\Check-In,Out\Check-InOutApp\Check-InOutApp\bin\Debug\Check-InOutApp.exe");
        }
    }
}
