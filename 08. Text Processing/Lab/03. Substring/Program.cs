using System;

namespace _03._Substring
{
    class Program
    {
        static void Main()
        {
            var word = Console.ReadLine().ToLower();
            var text = Console.ReadLine().ToLower();

            while (true)
            {
                var index = text.IndexOf(word);

                if (index < 0)
                {
                    break;
                }
                text = text.Remove(index, word.Length);
            }

            Console.WriteLine(text);
        }
    }
}
