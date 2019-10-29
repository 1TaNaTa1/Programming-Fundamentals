using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double maxVolume = 0.0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currVolume = Math.PI * radius * radius * height;
                if (maxVolume < currVolume)
                {
                    maxVolume = currVolume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);


        }
    }
}
