using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopPro
{
    public class Customer
    {
        
            private int id;
            private string firstName;
            private string lastName;
            private decimal balance;
            private string ticketType;
            private string status;
            private string tagId;
            

            public int Id { get { return id; } }
            public string FirstName { get { return firstName; } }
            public string LastName { get { return lastName; } }
            public decimal Balance { get { return balance; }
            set { balance = value; } }
            public string TicketType { get { return ticketType; }  }
            public string Status { get { return status; }  }
            public string TagId { get { return tagId; } }

            public Customer(int id, string firstName, string lastName, decimal balance, string ticketType, string status, string tagId)
            {
                this.id = id;
                this.firstName = firstName;
                this.lastName = lastName;
                this.balance = balance;
                this.ticketType = ticketType;
                this.status = status;
                this.tagId = tagId;
                

            }  
    }
}
