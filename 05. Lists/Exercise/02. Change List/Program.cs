using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split();

            while(command[0] != "end")
            {
                if(command[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(command[1]));
                }
                else if(command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int element = int.Parse(command[1]);
                    numbers.Insert(index, element);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
