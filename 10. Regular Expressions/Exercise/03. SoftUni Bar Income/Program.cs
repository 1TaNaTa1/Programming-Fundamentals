using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%.*<(?<product>\w+)>.*\|(?<quantity>\d+)\|.*?(?<price>\d+.?\d{0,2})\$.*");

            var input = Console.ReadLine();

            var totalIncome = 0.0;

            while (input != "end of shift")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    var customer = match.Groups["customer"].Value;
                    var product = match.Groups["product"].Value;
                    var quantity = int.Parse(match.Groups["quantity"].Value);
                    var price = double.Parse(match.Groups["price"].Value);

                    var totalPrice = quantity * price;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");

                    totalIncome += totalPrice;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
