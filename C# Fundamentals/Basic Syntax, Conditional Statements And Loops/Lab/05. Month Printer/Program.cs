using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main()
        {
            string[] monthsAsText = { "January", "February", "March", "April", "May", "June", "July",
            "August", "September", "October", "November", "December", };

            int monthsAsNumbers = int.Parse(Console.ReadLine());

            if (monthsAsNumbers < 1 || monthsAsNumbers > 12)
                Console.WriteLine("Error!");
            else
                Console.WriteLine(monthsAsText[monthsAsNumbers - 1]);
        }
    }
}
