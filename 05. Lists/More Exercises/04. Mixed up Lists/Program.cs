using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            bool isFirstBigger = false;

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Count - i - 1 < 0)
                {
                    isFirstBigger = true;
                    break;
                }

                result.Add(firstList[i]);
                result.Add(secondList[secondList.Count - i - 1]);
            }

            result.Sort();

            if (isFirstBigger)
            {
                PrintResult(firstList, result, isFirstBigger);
            }
            else
            {
                PrintResult(secondList, result, isFirstBigger);
            }
        }

        private static void PrintResult(List<int> CheckList, List<int> result, bool isFirstBigger)
        {
            int min;
            int max;

            if (isFirstBigger)
            {
                min = Math.Min(CheckList[CheckList.Count - 1], CheckList[CheckList.Count - 2]);
                max = Math.Max(CheckList[CheckList.Count - 1], CheckList[CheckList.Count - 2]);
            }
            else
            {
                min = Math.Min(CheckList[0], CheckList[1]);
                max = Math.Max(CheckList[0], CheckList[1]);
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > min && result[i] < max)
                {
                    Console.Write(result[i] + " ");
                }
            }
        }
    }
}
