using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            int tempNum = num;
            while (tempNum != 0)
            {
                int digitFactorial = 1;
                int digit = tempNum % 10;

                for (int i = digit; i > 0; i--)
                {
                    digitFactorial *= i;
                }

                sumOfDigits += digitFactorial;

                tempNum /= 10;
            }

            if (num == sumOfDigits)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
