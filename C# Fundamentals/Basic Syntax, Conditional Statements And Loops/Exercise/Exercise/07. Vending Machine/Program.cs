using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            decimal totalMoney = 0;

            while (input != "start")
            {
                decimal money = decimal.Parse(input);

                switch (money)
                {
                    case 0.1m:
                    case 0.2m:
                    case 0.5m:
                    case 1.0m:
                    case 2.0m:
                        totalMoney += money;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {money}");
                        break;
                }

                input = Console.ReadLine().ToLower();
            }

            input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                decimal price = 0;
                switch (input)
                {
                    case "nuts":
                        price = 2.0m;
                        break;
                    case "water":
                        price = 0.7m;
                        break;
                    case "crisps":
                        price = 1.5m;
                        break;
                    case "soda":
                        price = 0.8m;
                        break;
                    case "coke":
                        price = 1.0m;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (totalMoney >= price && price != 0)
                {
                    Console.WriteLine($"Purchased {input}");
                    totalMoney -= price;
                }
                else if (price != 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }


                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
