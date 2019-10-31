using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int passengers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (capacity - wagons[i] >= passengers)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
