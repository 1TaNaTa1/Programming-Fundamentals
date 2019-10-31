using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._List_Manipulation_Basics
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

            bool isChanged = false;
            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Contains")
                {
                    PrintIfContain(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEven(numbers);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOdd(numbers);
                }
                else if (command[0] == "GetSum")
                {
                    PrintSum(numbers);
                }
                else if (command[0] == "Filter")
                {
                    FilterList(numbers, command[1], int.Parse(command[2]));
                }

                command = Console.ReadLine().Split();
            }

            if (isChanged == true)
                Console.WriteLine(string.Join(" ", numbers));
        }

        static void PrintIfContain(List<int> numbers, int num)
        {
            foreach (int item in numbers)
            {
                if (item == num)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No such number");
        }

        static void PrintEven(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
        }

        static void PrintOdd(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 2 == 1)
                {
                    Console.Write(item + " ");
                }
            }
        }

        static void PrintSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int item in numbers)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }

        static void FilterList(List<int> numbers, string @operator, int num)
        {
            switch (@operator)
            {
                case ">":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > num)));
                    break;
                case "<":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < num)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= num)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= num)));
                    break;
                default:
                    break;
            }
        }
    }
}
