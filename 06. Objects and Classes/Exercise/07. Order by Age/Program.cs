using System;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "End")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(name, id, age);

                people.Add(person);

                input = Console.ReadLine().Split(' ');
            }

            people.Sort((x, y) => x.Age.CompareTo(y.Age));

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
