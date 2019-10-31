using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main()
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if(firstPlayerCards.Count == 0)
                {
                    int sum = secondPlayerCards.Sum();

                    Console.WriteLine($"Second player wins! Sum: {sum}");

                    break;
                }
                else if(secondPlayerCards.Count == 0)
                {
                    int sum = firstPlayerCards.Sum();

                    Console.WriteLine($"First player wins! Sum: {sum}");

                    break;
                }

                if(firstPlayerCards[0] == secondPlayerCards[0])
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
                else if(firstPlayerCards[0] > secondPlayerCards[0])
                {
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.RemoveAt(0);

                    firstPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.RemoveAt(0);
                }
                else
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.RemoveAt(0);

                    secondPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.RemoveAt(0);
                }
            }
        }
    }
}
