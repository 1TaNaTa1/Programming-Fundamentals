using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main()
        {
            int countOfWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                words[word].Add(synonym);
            }

            foreach (var item in words)
            {
                string word = item.Key;
                List<string> synonyms = item.Value;

                Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
            }
        }
    }
}
