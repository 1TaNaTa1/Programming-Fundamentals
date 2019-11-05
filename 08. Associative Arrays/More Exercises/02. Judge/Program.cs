using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" -> ");

            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            SortedDictionary<string, int> individualResults = new SortedDictionary<string, int>();

            while(input[0] != "no more time")
            {
                string username = input[0];
                string contestName = input[1];
                int points = int.Parse(input[2]);

                bool isPointsHigher = false;

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = new Dictionary<string, int>();
                }

                if (contests[contestName].ContainsKey(username))
                {
                    if (contests[contestName][username] < points)
                    {
                        int tempPoints = points - contests[contestName][username];

                        contests[contestName][username] = points;

                        points = tempPoints;

                        isPointsHigher = true;
                    }
                }
                else
                {
                    contests[contestName][username] = points;

                    isPointsHigher = true;
                }

                if (!individualResults.ContainsKey(username))
                {
                    individualResults[username] = 0;
                }

                if (isPointsHigher)
                {
                    individualResults[username] += points;
                }

                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int count = 1;
                foreach (var user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{count}. {user.Key} <::> {user.Value}");

                    count++;
                }
            }

            Console.WriteLine("Individual standings:");

            int counter = 1;
            foreach (var user in individualResults.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{counter}. {user.Key} -> {user.Value}");
                counter++;
            }
        }
    }
}
