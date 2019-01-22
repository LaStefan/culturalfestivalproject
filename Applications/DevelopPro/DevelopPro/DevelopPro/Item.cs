using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidget22;
using Phidget22.Events;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace DevelopPro
{
    public class Item
    {
        private int loanId;
        private string loanName;
        private decimal deposit;
        private int stock;
        private int quantity;
        private DateTime startDate = DateTime.Now;

        public int LoanId { get { return this.loanId; } }
        public string LoanName { get { return this.loanName; } }
        public decimal Deposit { get { return this.deposit; } set { deposit = value; } }
        public int Stock { get { return this.stock; } }
        public int Quantity { get { return this.quantity; } }
        public DateTime StartDate { get { return this.startDate; } }

        public Item(int LoanId, string LoanName, decimal Deposit, int Stock)
        {
            this.loanId = LoanId;
            this.loanName = LoanName;
            this.deposit = Deposit;
            this.stock = Stock;
        }

        public Item(int LoanId, string LoanName, decimal Deposit, int Quantity, DateTime StartDate)
        {
            this.loanId = LoanId;
            this.loanName = LoanName;
            this.deposit = Deposit;
            this.quantity = Quantity;
            this.startDate = StartDate;
        }

        public override string ToString()
        {
            return (this.loanId.ToString() + " " + this.loanName + this.startDate.ToString() + this.deposit.ToString());
        }       
    }
}
