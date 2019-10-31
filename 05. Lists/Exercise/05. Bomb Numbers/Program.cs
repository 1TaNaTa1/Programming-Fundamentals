using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            while (numbers.Contains(bombNumber))
            {
                int bombIndex = numbers.IndexOf(bombNumber);

                for (int i = 0; i < bombPower; i++)
                {
                    if(bombIndex + 1 < numbers.Count)
                    {
                        numbers.RemoveAt(bombIndex + 1);
                    }
                }

                for (int i = 0; i <= bombPower; i++)
                {
                    if(bombIndex - i >= 0)
                    {
                        numbers.RemoveAt(bombIndex - i);
                    }
                }
            }

            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
