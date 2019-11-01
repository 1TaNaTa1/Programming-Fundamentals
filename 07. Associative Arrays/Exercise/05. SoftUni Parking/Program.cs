using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main()
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> registrations = new Dictionary<string, string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ');

                string command = commandArgs[0];
                string username = commandArgs[1];

                if(command == "register")
                {
                    string licensePlateNumber = commandArgs[2];

                    if (!registrations.ContainsKey(username))
                    {
                        registrations[username] = licensePlateNumber;

                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if(command == "unregister")
                {
                    if (registrations.ContainsKey(username))
                    {
                        registrations.Remove(username);

                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var kvp in registrations)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
