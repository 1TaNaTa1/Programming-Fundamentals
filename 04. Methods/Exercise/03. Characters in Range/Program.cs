using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintASCIIInRange(firstChar, secondChar);
        }

        static void PrintASCIIInRange(char a, char b)
        {
            char lowerLimit;
            char upperLimit;

            if (a > b)
            {
                lowerLimit = b;
                upperLimit = a;
            }
            else
            {
                lowerLimit = a;
                upperLimit = b;
            }

            for (int i = (int)lowerLimit + 1; i < (int)upperLimit; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
