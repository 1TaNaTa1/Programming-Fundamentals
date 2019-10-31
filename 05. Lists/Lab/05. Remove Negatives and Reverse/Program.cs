using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] >= 0)
                    result.Add(numbers[i]);

            if (result.Count == 0)
                Console.WriteLine("empty");
            else
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}
