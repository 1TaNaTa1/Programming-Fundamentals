using System;

namespace _01._Biscuits_Factory
{
    class Program
    {
        static void Main()
        {
            int biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competeNumberOfBiscuitsFor30Days = int.Parse(Console.ReadLine());

            int biscuitPerDay = biscuitsPerDayPerWorker * countOfWorkers;
            int biscuitsEvery3thDay = (int)Math.Floor(biscuitPerDay * 0.75);

            int biscuitsPerMonth = 0;
            for (int i = 1; i <= 30; i++)
            {
                if(i % 3 == 0)
                {
                    biscuitsPerMonth += biscuitsEvery3thDay;
                }
                else
                {
                    biscuitsPerMonth += biscuitPerDay;
                }
            }

            int difference = Math.Abs(competeNumberOfBiscuitsFor30Days - biscuitsPerMonth);

            double percentage = difference / (double)competeNumberOfBiscuitsFor30Days * 100;

            Console.WriteLine($"You have produced {biscuitsPerMonth} biscuits for the past month.");

            if(biscuitsPerMonth > competeNumberOfBiscuitsFor30Days)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");

            }
        }
    }
}
