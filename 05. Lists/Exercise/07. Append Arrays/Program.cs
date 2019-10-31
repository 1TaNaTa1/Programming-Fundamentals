using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split("|").ToList();

            input.Reverse();

            List<int> numbers = new List<int>();

            foreach (string item in input)
            {
                numbers.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
