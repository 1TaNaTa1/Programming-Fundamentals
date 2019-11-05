using System;
using System.Text;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var sb = new StringBuilder();

            while (input != "end")
            {
                sb.Append(input);
                sb.Append(" = ");

                string reversedString = new string(input.Reverse().ToArray());

                sb.Append(reversedString);
                sb.Append(Environment.NewLine);

                input = Console.ReadLine();
            }

            Console.WriteLine(sb);
        }
    }
}
