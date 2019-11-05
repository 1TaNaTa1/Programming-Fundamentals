using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var digits = new StringBuilder();
            var letters = new StringBuilder();
            var otherChars = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                    digits.Append(input[i]);
                else if (char.IsLetter(input[i]))
                    letters.Append(input[i]);
                else
                    otherChars.Append(input[i]);
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
