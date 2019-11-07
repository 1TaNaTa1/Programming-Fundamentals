using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[numbers.Length];

            // Need to fix

            for (int i = 0; i < numbers.Length; i++)
            {
                len[i] = 1;

                for (int j = 0; j < i - 1; j++)
                {
                    
                }
            }

            Console.WriteLine(string.Join(' ', len));
        }
    }
}
