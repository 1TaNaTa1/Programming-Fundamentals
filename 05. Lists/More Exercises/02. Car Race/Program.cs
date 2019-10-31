using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Car_Race
{
    class Program
    {
        static void Main()
        {
            List<int> timeForEachStep = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double leftCar = 0;
            double rightCar = 0;

            for (int i = 0; i < timeForEachStep.Count / 2; i++)
            {
                leftCar += timeForEachStep[i];
                if(timeForEachStep[i] == 0)
                {
                    leftCar -= leftCar * 0.2;
                }

                rightCar += timeForEachStep[timeForEachStep.Count - i - 1];
                if(timeForEachStep[timeForEachStep.Count - i - 1] == 0)
                {
                    rightCar -= rightCar * 0.2;
                }
            }

            if(leftCar < rightCar)
            {
                Console.WriteLine("The winner is left with total time: {0}", leftCar);
            }
            else
            {
                Console.WriteLine("The winner is right with total time: {0}", rightCar);
            }
        }
    }
}
