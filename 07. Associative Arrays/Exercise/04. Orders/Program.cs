using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string[] input = Console.ReadLine().Split(' ');

            while(input[0] != "buy")
            {
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = new Product(price, quantity);
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var kvp in products)
            {
                double totalPrice = kvp.Value.Price * kvp.Value.Quantity;

                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
