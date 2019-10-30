using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                        isTopInteger = false;
                }

                if (isTopInteger)
                    Console.Write(numbers[i] + " ");
            }

            Console.Write(numbers[numbers.Length - 1]);
        }
    }
}
