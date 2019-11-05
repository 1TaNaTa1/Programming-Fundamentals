using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" : ");

            while(input[0] != "end")
            {
                string course = input[0];
                string student = input[1];

                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string>();
                }

                courses[course].Add(student);

                input = Console.ReadLine().Split(" : ");
            }

            courses = courses
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (string student in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
