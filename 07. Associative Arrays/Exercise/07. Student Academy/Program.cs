using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main()
        {
            int numOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }

                students[name].Add(grade);
            }

            students = students
                .Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
