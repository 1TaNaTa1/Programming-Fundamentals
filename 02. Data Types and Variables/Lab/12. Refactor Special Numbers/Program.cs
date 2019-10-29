using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int temp = i;
                int sum = 0;

                while (i != 0)
                {
                    sum += i % 10;
                    i /= 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", temp, isSpecial);

                i = temp;
            }
        }
    }
}
