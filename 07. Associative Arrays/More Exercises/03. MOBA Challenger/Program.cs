using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, SortedDictionary<string, int>> playerPool = new Dictionary<string, SortedDictionary<string, int>>();
            SortedDictionary<string, int> totalSkillPointsPerPlayer = new SortedDictionary<string, int>();

            string input = Console.ReadLine();

            while(input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] splitedInput = input.Split(" -> ");

                    string player = splitedInput[0];
                    string position = splitedInput[1];
                    int skill = int.Parse(splitedInput[2]);

                    if (!playerPool.ContainsKey(player))
                    {
                        playerPool[player] = new SortedDictionary<string, int>();
                        totalSkillPointsPerPlayer[player] = 0;
                    }

                    if (!playerPool[player].ContainsKey(position))
                    {
                        playerPool[player][position] = skill;
                        totalSkillPointsPerPlayer[player] += skill;
                    }
                    else
                    {
                        if(playerPool[player][position] < skill)
                        {
                            playerPool[player][position] = skill;
                            totalSkillPointsPerPlayer[player] += skill - totalSkillPointsPerPlayer[player];
                        }
                    }
                }
                else
                {
                    string[] splitedInput = input.Split(" vs ");

                    string firstPlayer = splitedInput[0];
                    string secondPlayer = splitedInput[1];

                    if(playerPool.ContainsKey(firstPlayer) && playerPool.ContainsKey(secondPlayer))
                    {
                        foreach (var firstPlayerPosition in playerPool[firstPlayer])
                        {
                            bool isFound = false;
                            foreach (var secondPlayerPosition in playerPool[secondPlayer])
                            {
                                if(firstPlayerPosition.Key == secondPlayerPosition.Key)
                                {
                                    if(totalSkillPointsPerPlayer[firstPlayer] > totalSkillPointsPerPlayer[secondPlayer])
                                    {
                                        playerPool.Remove(secondPlayer);
                                        totalSkillPointsPerPlayer.Remove(secondPlayer);
                                    }
                                    else if(totalSkillPointsPerPlayer[firstPlayer] < totalSkillPointsPerPlayer[secondPlayer])
                                    {
                                        playerPool.Remove(firstPlayer);
                                        totalSkillPointsPerPlayer.Remove(firstPlayer);
                                    }

                                    isFound = true;

                                    break;
                                }
                            }

                            if (isFound)
                            {
                                break;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in totalSkillPointsPerPlayer.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} skill");

                foreach (var position in playerPool[kvp.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
