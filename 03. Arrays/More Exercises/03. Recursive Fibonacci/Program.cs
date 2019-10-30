using System;
using System.Collections.Generic;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        public static Dictionary<int, long> fibonacciCache = new Dictionary<int, long>();

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        public static long GetFibonacci(int n)
        {
            if (fibonacciCache.ContainsKey(n))
            {
                return fibonacciCache[n];
            }

            long number;

            switch (n)
            {
                case 1:
                case 2:
                    return 1;
                default:
                    number = GetFibonacci(n - 1) + GetFibonacci(n - 2);
                    break;
            }

            if (!fibonacciCache.ContainsKey(n))
            {
                fibonacciCache.Add(n, number);
            }

            return number;
        }
    }
}