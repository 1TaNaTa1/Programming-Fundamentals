using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            List<Box> boxes = new List<Box>();

            while (input[0] != "end")
            {
                string serialNumber = input[0];
                string itemName = input[1];
                int quantity = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Quantity = quantity
                };
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;

                box.PriceBox = itemPrice * quantity;

                boxes.Add(box);

                input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }

            boxes.Sort((x, y) => y.PriceBox.CompareTo(x.PriceBox));

            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }
    }
}
