using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;

            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            Console.WriteLine(sumOfDigits);
        }
    }
}
