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
            private List<Customer> customers;

            public int Id { get; set; }
            public int FirstName { get; set; }
            public int LastName { get; set; }
            public int Balance { get; set; }
            public int TicketType { get; set; }
            public int Status { get; set; }
            public int TagId { get; set; }

            public Customer(int id, string firstName, string lastName, decimal balance, string ticketType, string status, string tagId)
            {
                this.id = id;
                this.firstName = firstName;
                this.lastName = lastName;
                this.balance = balance;
                this.ticketType = ticketType;
                this.status = status;
                this.tagId = tagId;
                customers = new List<Customer>();

            }  
    }
}
