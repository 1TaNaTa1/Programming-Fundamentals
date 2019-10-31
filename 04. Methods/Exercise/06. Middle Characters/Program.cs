using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            PrintMiddleChar(input);
        }

        static void PrintMiddleChar(string text)
        {
            int middlePoint = text.Length / 2;

            if (text.Length % 2 == 0)
                Console.WriteLine(text[middlePoint - 1] + "" + text[middlePoint]);
            else
                Console.WriteLine(text[middlePoint]);
        }
    }
}
