using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Students_2._0
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

                if (IsStudentExisting(students, firstName, secondName))
                {
                    Student student = GetStudent(students, firstName, secondName);

                    student.Age = age;
                    student.Hometown = hometown;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        SecondName = secondName,
                        Age = age,
                        Hometown = hometown
                    };

                    students.Add(student);
                }

                input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.SecondName}" +
                        $" is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string secondName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.SecondName == secondName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string secondName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.SecondName == secondName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}
