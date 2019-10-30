using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main()
        {
            string[] daysAsText = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayAsNumber = int.Parse(Console.ReadLine());

            if (dayAsNumber < 1 || dayAsNumber > 7)
                Console.WriteLine("Invalid day!");
            else
                Console.WriteLine(daysAsText[dayAsNumber - 1]);
        }
    }
}
