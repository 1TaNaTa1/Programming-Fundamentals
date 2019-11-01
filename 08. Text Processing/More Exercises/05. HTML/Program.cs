using System;

namespace _05._HTML
{
    class Program
    {
        static void Main()
        {
            var title = Console.ReadLine();
            PrintInHTMLFormat("h1", title);

            var content = Console.ReadLine();
            PrintInHTMLFormat("article", content);

            var input = Console.ReadLine();

            while(input != "end of comments")
            {
                PrintInHTMLFormat("div", input);
                input = Console.ReadLine();
            }
        }

        static void PrintInHTMLFormat(string tagName, string content)
        {
            Console.WriteLine($"<{tagName}>");
            Console.WriteLine($"\t{content}");
            Console.WriteLine($"</{tagName}>");
        }
    }
}
