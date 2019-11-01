using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Orders
{
    public class Product
    {
        public Product(double price, int quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
