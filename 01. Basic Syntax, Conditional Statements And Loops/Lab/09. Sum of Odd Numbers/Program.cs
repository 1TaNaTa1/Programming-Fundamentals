using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0, j = 1; i < num; i++, j += 2)
            {
                Console.WriteLine(j);
                sum += j;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
