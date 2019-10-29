using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            decimal priceOfLightsabers = decimal.Parse(Console.ReadLine());
            decimal priceOfRobes = decimal.Parse(Console.ReadLine());
            decimal priceOfBelts = decimal.Parse(Console.ReadLine());

            priceOfBelts *= numOfStudents - (numOfStudents / 6);
            priceOfRobes *= numOfStudents;

            priceOfLightsabers *= (numOfStudents + (int)Math.Ceiling(numOfStudents * 0.1));

            decimal totalMoneyNeeded = priceOfLightsabers + priceOfRobes + priceOfBelts;

            if (totalMoneyNeeded <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:f2}lv.");
            }
            else
            {
                decimal neededMoney = totalMoneyNeeded - money;
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }
    }
}
