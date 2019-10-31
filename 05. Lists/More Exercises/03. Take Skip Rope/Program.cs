using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<char> nonNumbers = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            string result = string.Empty;

            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    if(nonNumbers.Count == j)
                    {
                        break;
                    }

                    result += nonNumbers[j];
                }

                if (nonNumbers.Count <= takeList[i] + skipList[i])
                {
                    break;
                }

                nonNumbers.RemoveRange(0, takeList[i] + skipList[i]);
            }

            Console.WriteLine(result);
        }
    }
}
