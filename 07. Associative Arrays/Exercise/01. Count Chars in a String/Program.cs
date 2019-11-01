using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Dictionary<char, int> letterCounts = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (letter == ' ')
                {
                    continue;
                }

                if (!letterCounts.ContainsKey(letter))
                {
                    letterCounts[letter] = 0;
                }

                letterCounts[letter]++;
            }

            foreach (var kvp in letterCounts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
