using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('>');

            var result = new StringBuilder();

            result.Append(input[0]);

            int power = 0;

            for (int i = 1; i < input.Length; i++)
            {
                result.Append(">");

                var currString = input[i];

                power += int.Parse(currString[0].ToString());

                if (power > currString.Length)
                {
                    power -= currString.Length;
                }
                else
                {
                    result.Append(currString.Substring(power));
                    power = 0;
                }

            }

            Console.WriteLine(result);
        }
    }
}
