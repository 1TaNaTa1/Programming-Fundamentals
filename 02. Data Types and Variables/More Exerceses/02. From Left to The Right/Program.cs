using System;
using System.Linq;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();

                BigInteger[] numbersSplit = numbers.Split().Select(BigInteger.Parse).ToArray();
                int sum = 0;

                if (numbersSplit[0] > numbersSplit[1])
                {
                    while (numbersSplit[0] != 0)
                    {
                        sum += Math.Abs((int)(numbersSplit[0] % 10));
                        numbersSplit[0] /= 10;
                    }
                }
                else
                {
                    while (numbersSplit[1] != 0)
                    {
                        sum += Math.Abs((int)(numbersSplit[1] % 10));
                        numbersSplit[1] /= 10;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
