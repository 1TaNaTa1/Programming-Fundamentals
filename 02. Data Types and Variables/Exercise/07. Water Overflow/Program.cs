using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main()
        {
            int maxCapacity = 255;
            int currWaterInTank = 0;


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (maxCapacity >= currWaterInTank + liters)
                {
                    currWaterInTank += liters;
                }
                else
                    Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(currWaterInTank);
        }
    }
}
