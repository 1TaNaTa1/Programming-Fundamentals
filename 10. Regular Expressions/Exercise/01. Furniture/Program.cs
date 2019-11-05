using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>[0-9]+\.*[0-9]+)!(?<quantity>[0-9]+)");

            var input = Console.ReadLine();

            var totalPrice = 0.0;

            var furnitureNames = new List<string>();

            while (input != "Purchase")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    furnitureNames.Add(match.Groups["name"].Value);

                    var currPrice = double.Parse(match.Groups["price"].Value);
                    var currQuantity = int.Parse(match.Groups["quantity"].Value);

                    totalPrice += currPrice * currQuantity;
                }

                input = Console.ReadLine();
            }


            Console.WriteLine("Bought furniture:");
            if(furnitureNames.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitureNames));
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
