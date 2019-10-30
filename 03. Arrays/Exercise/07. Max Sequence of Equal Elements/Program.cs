using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int currCounter = 0;
            int finalCounter = 0;
            int value = 0;

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currCounter++;

                    if (currCounter >= finalCounter)
                    {
                        finalCounter = currCounter;
                        value = numbers[i];
                    }
                }
                else
                {
                    currCounter = 0;
                }
            }

            //Because of the missing one
            finalCounter++;

            for (int i = 0; i < finalCounter; i++)
            {
                Console.Write(value + " ");
            }
        }
    }
}
