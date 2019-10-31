using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main()
        {
            List<int> distances = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (distances.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                int value;
                if (index < 0)
                {
                    value = distances[0];
                    distances[0] = distances[distances.Count - 1];
                }
                else if (index >= distances.Count)
                {
                    value = distances[distances.Count - 1];
                    distances[distances.Count - 1] = distances[0];
                }
                else
                {
                    value = distances[index];

                    distances.RemoveAt(index);
                }

                sum += value;

                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] <= value)
                    {
                        distances[i] += value;
                    }
                    else
                    {
                        distances[i] -= value;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
