using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopApp.classes
{
    public class Product
    {
        private double price;

        public int ID { get; set; }
        public String Name { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (price > 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }

        public byte[] Imgdata { get; set; }

        public int Quantity { get; set; }

        public Product(int id, string name, double price, int quantity, byte[] imgdata)
        {
            ID = id;
            Name = name;
            Price = price;
            Imgdata = imgdata;
            Quantity = quantity;
        }
    }
}
