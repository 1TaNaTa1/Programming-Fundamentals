using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine()
                .Split(' ')
                .ToList();

            var random = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                var randomIndex = random.Next(0, list.Count);

                var el = list[i];

                list[i] = list[randomIndex];
                list[randomIndex] = el;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
