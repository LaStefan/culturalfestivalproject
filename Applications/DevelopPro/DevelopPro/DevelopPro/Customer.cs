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
     class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private decimal balance;
        private string ticketType;
        private string status;
        private string tagId;
        private List<Customer> customers;

        public Customer(int id,string firstName,string lastName,decimal balance,string ticketType,string status,string tagId)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
            this.ticketType = ticketType;
            this.status = status;
            this.tagId = tagId;
            customers= new List<Customer>();

        }
        
        
        
    }
}
