using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < n + 'a'; i++)
            {
                for (int j = 'a'; j < n + 'a'; j++)
                {
                    for (int k = 'a'; k < n + 'a'; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
