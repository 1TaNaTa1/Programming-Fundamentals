using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main()
        {
            string[] phrases = new string[] { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            string[] events = new string[] { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            string[] authors = new string[] { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" };

            string[] cities = new string[] { "Burgas", 
                "Sofia", 
                "Plovdiv", 
                "Varna", 
                "Ruse"};

            int num = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < num; i++)
            {
                int rand = random.Next(0, phrases.Length);
                string message = phrases[rand];

                rand = random.Next(0, events.Length);
                message += " " + events[rand];

                rand = random.Next(0, authors.Length);
                message += " " + authors[rand];

                rand = random.Next(0, cities.Length);
                message += " " + cities[rand];

                Console.WriteLine(message);
            }
        }
    }
}
