using System;

namespace _04._Refactor_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLower());
            }
        }
    }
}
