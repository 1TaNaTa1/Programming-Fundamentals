using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(':');

            Dictionary<string, string> contestsData = new Dictionary<string, string>();

            while(input[0] != "end of contests")
            {
                string contest = input[0];
                string password = input[1];

                if (contestsData.ContainsKey(contest))
                {
                    contestsData[contest] = null;
                }

                contestsData[contest] = password;

                input = Console.ReadLine().Split(':');
            }

            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();

            input = Console.ReadLine().Split("=>");

            while(input[0] != "end of submissions")
            {
                string contest = input[0];
                string password = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);

                if (contestsData.ContainsKey(contest))
                {
                    if(contestsData[contest] == password)
                    {
                        if (!results.ContainsKey(username))
                        {
                            results[username] = new Dictionary<string, int>();
                        }

                        if (results[username].ContainsKey(contest))
                        {
                            if(results[username][contest] < points)
                            {
                                results[username][contest] = points;
                            }
                        }
                        else
                        {
                            results[username][contest] = points;
                        }
                    }
                }

                input = Console.ReadLine().Split("=>");
            }

            string bestCandidate = null;
            int maxResult = 0;

            foreach (var candidate in results)
            {
                int totalPoints = 0;

                foreach (var contest in candidate.Value)
                {
                    totalPoints += contest.Value;
                }

                if(totalPoints > maxResult)
                {
                    maxResult = totalPoints;
                    bestCandidate = candidate.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxResult} points.");
            Console.WriteLine("Ranking: ");

            foreach (var candidate in results.OrderBy(x => x.Key))
            {
                Console.WriteLine(candidate.Key);

                foreach (var contest in candidate.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
