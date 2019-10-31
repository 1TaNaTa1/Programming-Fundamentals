using System;

namespace _02._Articles
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                input = Console.ReadLine().Split(": ");

                string command = input[0];
                string value = input[1];

                if (command == "Edit")
                {
                    article.Edit(value);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(value);
                }
                else if (command == "Rename")
                {
                    article.Rename(value);
                }
            }

            Console.WriteLine(article);
        }
    }
}
