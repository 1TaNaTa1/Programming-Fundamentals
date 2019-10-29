using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());

            int daysMined = 0;
            int storage = 0;
            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                while (yield >= 100)
                {
                    storage += yield;
                    storage -= 26;

                    yield -= 10;

                    daysMined++;
                }

                storage -= 26;

                Console.WriteLine(daysMined);
                Console.WriteLine(storage);
            }
        }
    }
}
