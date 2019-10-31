using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            VowelsCount(input);
        }

        static void VowelsCount(string text)
        {
            int count = 0;
            string vowels = "aeiou";

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (text[i] == vowels[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
