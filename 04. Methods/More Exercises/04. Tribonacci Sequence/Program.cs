using System;
using System.Numerics;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine(0);
            }
            else if (num == 1)
            {
                Console.Write(1);
            }
            else if (num == 2)
            {
                Console.Write("1 1");
            }
            else if (num == 3)
            {
                Console.Write("1 1 2");
            }
            else
            {
                Console.Write("1 1 2 ");
                GetTribonacci(num);
            }
        }

        static void GetTribonacci(int num)
        {
            BigInteger minus1 = 2;
            BigInteger minus2 = 1;
            BigInteger minus3 = 1;
            BigInteger currNum;

            for (int i = 0; i < num - 3; i++)
            {
                currNum = minus1 + minus2 + minus3;
                minus3 = minus2;
                minus2 = minus1;
                minus1 = currNum;

                Console.Write(currNum + " ");
            }
        }
    }
}
