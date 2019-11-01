using System;
using System.Text;
using System.Linq;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main()
        {
            var NumberAsString = Console.ReadLine();
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (multiplier == 1)
            {
                Console.WriteLine(NumberAsString);
                return;
            }

            var result = new StringBuilder();
            var remainder = 0;

            for (int i = NumberAsString.Length - 1; i >= 0; i--)
            {
                var lastDigit = int.Parse(NumberAsString[i].ToString());

                var digitMultiplied = lastDigit * multiplier + remainder;

                result.Append(digitMultiplied % 10);

                remainder = digitMultiplied / 10;
            }

            if(remainder != 0)
            {
                result.Append(remainder);
            }

            Console.WriteLine(string.Join("", result
                .ToString()
                .Reverse())
                .TrimStart('0'));
        }
    }
}
