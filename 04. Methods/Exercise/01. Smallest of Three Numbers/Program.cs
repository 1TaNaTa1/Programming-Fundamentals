
using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            PrintSmallestNumber(numbers);
        }

        static void PrintSmallestNumber(int[] numbers)
        {
            int smallesNum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallesNum)
                {
                    smallesNum = numbers[i];
                }
            }

            Console.WriteLine(smallesNum);
        }
    }
}
