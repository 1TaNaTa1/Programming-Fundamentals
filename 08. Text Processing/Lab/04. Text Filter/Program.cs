using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string replacement = new string('*', bannedWords[i].Length);

                text = text.Replace(bannedWords[i], replacement);
            }

            Console.WriteLine(text);
        }
    }
}
