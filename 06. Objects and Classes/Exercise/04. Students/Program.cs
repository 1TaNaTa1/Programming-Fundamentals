using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            int countOfStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfStudent; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }

            students.Sort((x, y) => y.Grade.CompareTo(x.Grade));

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
