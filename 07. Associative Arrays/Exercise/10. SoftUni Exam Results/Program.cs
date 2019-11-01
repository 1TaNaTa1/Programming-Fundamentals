using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('-');

            Dictionary<string, List<int>> userPoints = new Dictionary<string, List<int>>();
            Dictionary<string, int> submissionCounts = new Dictionary<string, int>();

            while (input[0] != "exam finished")
            {
                string username = input[0];

                if(input[1] != "banned")
                {
                    string language = input[1];
                    int points = int.Parse(input[2]);

                    if (!userPoints.ContainsKey(username))
                    {
                        userPoints[username] = new List<int>();
                    }

                    userPoints[username].Add(points);

                    if (!submissionCounts.ContainsKey(language))
                    {
                        submissionCounts[language] = 0;
                    }

                    submissionCounts[language]++;
                }
                else
                {
                    userPoints.Remove(username);
                }


                input = Console.ReadLine().Split('-');
            }

            Console.WriteLine("Results:");

            foreach (var user in userPoints.OrderByDescending(x => x.Value.Max()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value.Max()}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in submissionCounts.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
