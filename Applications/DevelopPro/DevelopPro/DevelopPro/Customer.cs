using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopPro
{
    public class Customer
    {
            private List<Customer> customers;

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Balance { get; set; }
            public string TicketType { get; set; }
            public string Status { get; set; }
            public string TagId { get; set; }

            public Customer(int id, string firstName, string lastName, decimal balance, string ticketType, string status, string tagId)
            {
                this.Id = id;
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Balance = balance;
                this.TicketType = ticketType;
                this.Status = status;
                this.TagId = tagId;
                customers = new List<Customer>();
            }  
    }
}
