using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase] = 0;
                }

                counts[wordInLowerCase]++;
            }


            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
