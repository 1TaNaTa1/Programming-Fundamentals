using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string[] commandInput = Console.ReadLine().Split();

            string command = commandInput[0];

            while (command != "3:1")
            {
                if (command == "merge")
                {
                    int startIndex = int.Parse(commandInput[1]);
                    int endIndex = int.Parse(commandInput[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }

                    for (int i = startIndex; i < endIndex; endIndex--)
                    {
                        input[i] += input[i + 1];
                        input.RemoveAt(i + 1);
                    }
                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandInput[1]);
                    int partitions = int.Parse(commandInput[2]);

                    string[] divisionResult = new string[partitions];
                    string stringToDivide = input[index];

                    int counter = 0;

                    for (int i = 0; i < partitions; i++)
                    {
                        for (int j = 0; j < stringToDivide.Length / partitions; j++)
                        {
                            divisionResult[i] += stringToDivide[counter];
                            counter++;
                        }
                    }

                    for (int i = 0; i < stringToDivide.Length % partitions; i++)
                    {
                        divisionResult[partitions - 1] += stringToDivide[counter];
                        counter++;
                    }

                    input.InsertRange(index, divisionResult);

                    input.RemoveAt(index + partitions);
                }

                commandInput = Console.ReadLine().Split();

                command = commandInput[0];
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
