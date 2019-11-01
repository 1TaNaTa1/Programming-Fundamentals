using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "End")
            {
                string companyName = input[0];
                string employeeId = input[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if (!companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }

                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine(kvp.Key);

                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
