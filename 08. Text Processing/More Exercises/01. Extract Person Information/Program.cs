using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main()
        {
            var numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                var text = Console.ReadLine();

                var startIndex = text.IndexOf('@') + 1;
                var length = text.IndexOf('|') - startIndex;

                var name = text.Substring(startIndex, length);

                startIndex = text.IndexOf('#') + 1;
                length = text.IndexOf('*') - startIndex;

                var age = int.Parse(text.Substring(startIndex, length));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
