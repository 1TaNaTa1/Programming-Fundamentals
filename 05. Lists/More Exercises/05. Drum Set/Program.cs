using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());

            List<int> initialQuality = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultQuality = new List<int>();

            resultQuality.AddRange(initialQuality);

            string input = Console.ReadLine();

            while(input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < resultQuality.Count; i++)
                {
                    if(resultQuality[i] <= hitPower)
                    {
                        double pricePerDrum = initialQuality[i] * 3;

                        if(money >= pricePerDrum)
                        {
                            money -= pricePerDrum;

                            resultQuality[i] = initialQuality[i];
                        }
                        else
                        {
                            resultQuality[i] = 0;
                        }
                    }
                    else
                    {
                        resultQuality[i] -= hitPower;
                    }
                }

                    input = Console.ReadLine();
            }

            resultQuality.RemoveAll(x => x == 0);

            Console.WriteLine(string.Join(" ",resultQuality));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
