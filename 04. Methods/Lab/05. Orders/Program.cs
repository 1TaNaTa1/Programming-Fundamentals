using System;

namespace _05._Orders
{
    class Program
    {
        static void Main()
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateTotalPrice(order, quantity);
        }

        static void CalculateTotalPrice(string product, int quantity)
        {
            double price = 0;

            if (product == "coffee")
                price = 1.5;
            else if (product == "coke")
                price = 1.4;
            else if (product == "water")
                price = 1;
            else if (product == "snacks")
                price = 2;

            Console.WriteLine($"{(price * quantity):f2}");
        }
    }
}
