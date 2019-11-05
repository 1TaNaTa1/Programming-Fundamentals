using System;
using System.Linq;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main()
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());

            var text = Console.ReadLine();

            var maxChar = Math.Max(firstChar, secondChar);
            var minChar = Math.Min(firstChar, secondChar);

            var result = text.Where(x => x > minChar && x < maxChar);

            var sum = 0;

            foreach (var symbol in result)
            {
                sum += symbol;
            }

            Console.WriteLine(sum);
        }
    }
}
