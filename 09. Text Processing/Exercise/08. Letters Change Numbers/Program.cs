using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var totalSum = 0.0;

            for (int i = 0; i < input.Length; i++)
            {
                var currString = input[i];

                var firstLetter = currString[0];
                var lastLetter = currString[currString.Length - 1];
                var number = double.Parse(currString.Substring(1, currString.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - 'A' + 1;
                }
                else
                {
                    number *= firstLetter - 'a' + 1;
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - 'A' + 1;
                }
                else
                {
                    number += lastLetter - 'a' + 1;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
