using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();

            int numOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTeams; i++)
            {
                string[] teamsToCreate = Console.ReadLine().Split('-');

                string teamCreator = teamsToCreate[0];
                string teamName = teamsToCreate[1];

                Team team = new Team(teamName, teamCreator);

                if (teams.Exists(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                }
                else if (teams.Exists(x => x.TeamCreator == teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");

                    teams.Add(team);
                }
            }

            string[] input = Console.ReadLine().Split("->");

            while (input[0] != "end of assignment")
            {
                string candidate = input[0];
                string teamName = input[1];

                if (!teams.Exists(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Exists(x => x.DoesContain(candidate) == candidate))
                {
                    Console.WriteLine($"Member {candidate} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.Name == teamName);

                    teams[index].Members.Add(candidate);
                }

                input = Console.ReadLine().Split("->");
            }

            List<string> disbandedTeams = new List<string>();

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Count == 0)
                {
                    disbandedTeams.Add(teams[i].Name);

                    teams.Remove(teams[i]);

                    i--;
                }
            }

            if (teams.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)));
            }

            Console.WriteLine("Teams to disband:");

            Console.WriteLine(string.Join(Environment.NewLine,
                disbandedTeams.OrderBy(x => x)));
        }
    }
}
