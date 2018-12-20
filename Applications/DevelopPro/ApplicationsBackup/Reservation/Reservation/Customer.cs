using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
     public class Customer
    {
        private string fname;
        private string lname;
        private decimal balance;
        private string ticketType;
        private string status;
        private string campId;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string TicketType
        {
            get { return ticketType; }
            set { ticketType = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string CampId
        {
            get { return campId; }
            set { campId = value; }
        }

        
        public Customer(string fname, string lname, decimal balance, string ticketType, string status, string campId)
        {
            this.fname = fname;
            this.lname = lname;
            this.balance = balance;
            this.ticketType = ticketType;
            this.status = status;
            this.campId = campId;
        }
    }
}
