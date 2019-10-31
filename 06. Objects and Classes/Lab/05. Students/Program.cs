using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            List<Student> students = new List<Student>();

            while (input[0] != "end")
            {
                string firstName = input[0];
                string secondName = input[1];
                int age = int.Parse(input[2]);
                string hometown = input[3];

                Student student = new Student
                {
                    FirstName = firstName,
                    SecondName = secondName,
                    Age = age,
                    Hometown = hometown
                };

                students.Add(student);

                input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown == town)
                {
                    Console.WriteLine($"{student.FirstName} " +
                        $"{student.SecondName} is {student.Age} years old.");
                }
            }
        }
    }
}
