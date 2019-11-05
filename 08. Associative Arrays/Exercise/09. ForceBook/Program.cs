using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> sideMembers = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                string side = string.Empty;
                string member = string.Empty;

                if (input.Contains("|"))
                {
                    string[] splitedInput = input.Split(" | ");

                    side += splitedInput[0];
                    member += splitedInput[1];

                    bool memberExists = false;

                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(member))
                        {
                            memberExists = true;
                            break;
                        }
                    }

                    if (!memberExists)
                    {
                        if (!sideMembers.ContainsKey(side))
                        {
                            sideMembers[side] = new List<string>();
                        }


                        if (!sideMembers[side].Contains(member))
                        {
                            sideMembers[side].Add(member);
                        }
                    }
                }
                else
                {
                    string[] splitedInput = input.Split(" -> ");

                    member += splitedInput[0];
                    side += splitedInput[1];

                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Remove(member))
                        {
                            break;
                        }
                    }

                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }

                    sideMembers[side].Add(member);

                    Console.WriteLine($"{member} joins the {side} side!");
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in sideMembers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                foreach (string forceUser in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine("! " + forceUser);
                }
            }
        }
    }
}
