using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Messaging
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            string result = string.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;

                while(numbers[i] != 0)
                {
                    sum += numbers[i] % 10;
                    numbers[i] /= 10;
                }

                while(sum >= text.Length)
                {
                    sum -= text.Length;
                }

                result += text[sum];
                text = text.Remove(sum, 1);
            }

            Console.WriteLine(result);
        }
    }
}
