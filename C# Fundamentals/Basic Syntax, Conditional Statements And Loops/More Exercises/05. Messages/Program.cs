using System;

namespace _05._Messages
{
    class Program
    {
        static void Main()
        {
            int letters = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < letters; i++)
            {
                string digits = Console.ReadLine();
                int digitLen = digits.Length;
                int mainDigit = digits[0] - '0';

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 0)
                {
                    message += " ";
                    continue;
                }

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = offset + digitLen - 1;

                message += (char)(letterIndex + 'a');
            }

            Console.WriteLine(message);
        }
    }
}
