using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        public static long GetFibonacci(int element)
        {
            switch (element)
            {
                case 1:
                case 2:
                    return 1;
                default:
                    long number = GetFibonacci(element - 1) + GetFibonacci(element - 2);
                    return number;
            }
        }
    }
}