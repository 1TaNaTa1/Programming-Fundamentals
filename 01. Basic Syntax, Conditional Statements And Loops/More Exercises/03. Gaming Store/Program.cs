using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            string[] games = { "OutFall 4", "CS: OG", "Zplinter Zell", "Honored 2", "RoverWatch", "RoverWatch Origins Edition" };
            double[] pricesPerGame = { 39.99, 15.99, 19.99, 59.99, 29.99, 39.99 };

            double totalSpent = 0;

            while (input != "Game Time")
            {
                bool isFound = false;
                for (int i = 0; i < games.Length; i++)
                {

                    if (games[i] == input)
                    {
                        isFound = true;
                        if (money >= pricesPerGame[i])
                        {
                            Console.WriteLine($"Bought {games[i]}");
                            money -= pricesPerGame[i];
                            totalSpent += pricesPerGame[i];
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                    }
                }
                if (isFound == false)
                {
                    Console.WriteLine("Not Found");
                }

                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${money:f2}");
        }
    }
}
