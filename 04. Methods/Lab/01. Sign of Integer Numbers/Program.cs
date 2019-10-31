using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            GetSignOfInteger(number);
        }

        static void GetSignOfInteger(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
            else if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
