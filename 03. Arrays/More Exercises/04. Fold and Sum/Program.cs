using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] firstRowNumbers = new int[numbers.Length / 2];
            int[] secondRowNumbers = new int[numbers.Length / 2];

            // Fills the firstRowNumbers in the following format
            // 1 2 3 4 5 6 7 8 - Numbers
            // 2 1 8 7         - firstRowNumbers
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                firstRowNumbers[i] = numbers[(numbers.Length / 4) - 1 - i];
                firstRowNumbers[firstRowNumbers.Length / 2 + i] = numbers[numbers.Length - 1 - i];
            }

            // Fills the secondRowNumbers in the following format
            // 1 2 3 4 5 6 7 8 - Old array
            // 3 4 5 6         - secondRowNumbers
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                secondRowNumbers[i] = numbers[(numbers.Length / 4) + i];
            }

            int[] result = new int[firstRowNumbers.Length];

            for (int i = 0; i < firstRowNumbers.Length; i++)
            {
                result[i] = firstRowNumbers[i] + secondRowNumbers[i];
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
