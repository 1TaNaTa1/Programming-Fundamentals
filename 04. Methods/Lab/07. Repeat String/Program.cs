using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeadString(input, count);

            Console.WriteLine(result);
        }

        static string RepeadString(string input, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
