using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                IsPalindromeNum(input);

                input = Console.ReadLine();
            }
        }

        static void IsPalindromeNum(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            Console.WriteLine("true");
        }
    }
}
