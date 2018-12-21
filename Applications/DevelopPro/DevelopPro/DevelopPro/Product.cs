using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopPro
{
   public class Product
    {
        //fields 
        private int id;
        private string name;
        private decimal price;
        private int stock;
        //properties
        public int Id { get { return id; } }
        public string ProductName { get { return name; } }
        public decimal ProductPrice { get { return price; } }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
            
        //constructor

        public Product(int id, string name,decimal price, int stock)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

       
    
        
    }
}
