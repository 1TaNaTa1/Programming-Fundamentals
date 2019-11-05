using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            List<string> newDeck = new List<string>();

            string command = Console.ReadLine();

            while (command != "Ready")
            {
                string[] splitedCommand = command.Split();

                if (splitedCommand[0] == "Add")
                {
                    if (!cards.Contains(splitedCommand[1]))
                    {
                        Console.WriteLine("Card not found.");
                    }
                    else
                    {
                        newDeck.Add(splitedCommand[1]);
                    }
                }
                else if (splitedCommand[0] == "Insert")
                {
                    int index = int.Parse(splitedCommand[2]);
                    if (index < 0 || index > newDeck.Count || !cards.Contains(splitedCommand[1]))
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        newDeck.Insert(index, splitedCommand[1]);
                    }
                }
                else if(splitedCommand[0] == "Remove")
                {
                    if (newDeck.Contains(splitedCommand[1]))
                    {
                        newDeck.Remove(splitedCommand[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if(splitedCommand[0] == "Swap")
                {
                    string oldCard = splitedCommand[1];
                    int index1 = newDeck.IndexOf(splitedCommand[1]);
                    int index2 = newDeck.IndexOf(splitedCommand[2]);
                    newDeck[index1] = splitedCommand[2];
                    newDeck[index2] = oldCard;
                }
                else if(splitedCommand[0] == "Shuffle" && splitedCommand[1] == "deck")
                {
                    newDeck.Reverse();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', newDeck));
        }
    }
}
