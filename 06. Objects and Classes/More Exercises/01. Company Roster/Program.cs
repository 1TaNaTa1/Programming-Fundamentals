using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main()
        {
            int numOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numOfEmployees; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];

                Employee employee = new Employee(name, salary, department);

                employees.Add(employee);
            }

            List<string> departments = new List<string>();

            foreach (Employee employee in employees)
            {
                if (!departments.Contains(employee.Department))
                {
                    departments.Add(employee.Department);
                }
            }

            double maxAverageSalary = 0;
            string targetDepartment = string.Empty;

            foreach (string department in departments)
            {
                double currAverageSalary = 0;

                currAverageSalary = employees.Where(x => x.Department == department)
                    .Sum(x => x.Salary);

                currAverageSalary /= employees.Where(x => x.Department == department)
                    .Count();

                if(currAverageSalary > maxAverageSalary)
                {
                    maxAverageSalary = currAverageSalary;
                    targetDepartment = department;
                }
            }

            List<Employee> bestDepartment = employees.Where(x => x.Department == targetDepartment)
                .OrderByDescending(x => x.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {targetDepartment}");
            Console.WriteLine(string.Join(Environment.NewLine, bestDepartment));
        }
    }
}
