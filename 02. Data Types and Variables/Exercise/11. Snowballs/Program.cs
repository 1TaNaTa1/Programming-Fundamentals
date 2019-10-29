using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] bestSnowball = new int[3];
            BigInteger snowballValue = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                if (snowballValue < BigInteger.Pow(snowballSnow / snowballTime, snowballQuality))
                {
                    snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                    bestSnowball[0] = snowballSnow;
                    bestSnowball[1] = snowballTime;
                    bestSnowball[2] = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowball[0]} : {bestSnowball[1]} = {snowballValue} ({bestSnowball[2]})");
        }
    }
}
