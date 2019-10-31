using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main()
        {
            List<Article> articles = new List<Article>();

            int numOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string sortCriteria = Console.ReadLine();

            if(sortCriteria == "title")
            {
                articles.Sort((x, y) => string.Compare(x.Title, y.Title));
            }
            else if(sortCriteria == "content")
            {
                articles.Sort((x, y) => string.Compare(x.Content, y.Content));
            }
            else if(sortCriteria == "author")
            {
                articles.Sort((x, y) => string.Compare(x.Author, y.Author));
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
