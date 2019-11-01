using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(" <:> ");

            while(input[0] != "Once upon a time")
            {
                string name = input[0];
                string colorOfHat = input[1];
                int physics = int.Parse(input[2]);

                string id = name + ":" + colorOfHat;

                if (!dwarfs.ContainsKey(id))
                {
                    dwarfs[id] = physics;
                }
                else
                {
                    if(dwarfs[id] < physics)
                    {
                        dwarfs[id] = physics;
                    }
                }

                input = Console.ReadLine().Split(" <:> ");
            }

            foreach (var dwarf in dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1]).Count()))
            {
                Console.WriteLine("({0}) {1} <-> {2}",
                    dwarf.Key.Split(':')[1],
                    dwarf.Key.Split(':')[0],
                    dwarf.Value);
            }
        }
    }
}
