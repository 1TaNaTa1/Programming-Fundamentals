using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int count = numbers.Count;

            for (int i = 0; i < count / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];

                numbers.RemoveAt(numbers.Count - 1);
            }

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
