using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                result.Append((char)(input[i] + 3));
            }

            Console.WriteLine(result);
        }
    }
}
