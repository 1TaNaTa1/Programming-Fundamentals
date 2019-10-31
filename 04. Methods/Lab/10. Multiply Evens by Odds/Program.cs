using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int sumEven = GetSumOfEven(num);
            int sumOdd = GetSumOfOdd(num);

            int multiple = GetMultipleOfEvenAndOdds(sumEven, sumOdd);

            Console.WriteLine(multiple);
        }

        static int GetSumOfEven(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                int digit = num % 10;

                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                num /= 10;
            }

            return sum;
        }

        static int GetSumOfOdd(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                int digit = num % 10;

                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                num /= 10;
            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            return sumEven * sumOdd;
        }
    }
}
