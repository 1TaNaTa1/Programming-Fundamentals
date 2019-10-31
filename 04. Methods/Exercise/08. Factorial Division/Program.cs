using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            long firstFactorial = CalculateFactorial(number);

            number = int.Parse(Console.ReadLine());

            long secondFactorial = CalculateFactorial(number);

            double result = (double)firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");
        }

        static long CalculateFactorial(int num)
        {
            long factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
