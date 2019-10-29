using System;

namespace _04._Back_in_30_Minutes
{
    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:d2}", hours, minutes);
        }
    }
}
