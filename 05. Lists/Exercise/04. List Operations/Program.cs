using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string command = input[0];

                switch (command)
                {
                    case "Add":
                        int number = int.Parse(input[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(input[1]);
                        int index = int.Parse(input[2]);

                        bool isIndexValid = IsValidIndex(index, 0, numbers.Count - 1);

                        if (isIndexValid)
                        {
                            numbers.Insert(index, number);
                        }

                        break;
                    case "Remove":
                        index = int.Parse(input[1]);

                        isIndexValid = IsValidIndex(index, 0, numbers.Count - 1);

                        if (isIndexValid)
                        {
                            numbers.RemoveAt(index);
                        }

                        break;
                    case "Shift":
                        string direction = input[1];
                        int count = int.Parse(input[2]);

                        if(direction == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int temp = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(temp);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int temp = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, temp);
                            }
                        }

                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static bool IsValidIndex(int index, int minRange, int maxRange)
        {
            if(index < minRange || index > maxRange)
            {
                Console.WriteLine("Invalid index");
                return false;
            }

            return true;
        }
    }
}
