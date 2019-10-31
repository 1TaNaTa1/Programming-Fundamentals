using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            
            List<string> guests = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine().Split();

                if(command[2] == "not")
                {
                    if (!guests.Remove(command[0]))
                    {
                        Console.WriteLine("{0} is not in the list!", command[0]);
                    }
                }
                else
                {
                    if (guests.Exists(x => x == command[0]))
                    {
                        Console.WriteLine("{0} is already in the list!", command[0]);
                    }
                    else
                    {
                        guests.Add(command[0]);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
