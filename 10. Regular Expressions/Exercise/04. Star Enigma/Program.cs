using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@"[starSTAR]");

            var countOfMessages = int.Parse(Console.ReadLine());

            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            for (int i = 0; i < countOfMessages; i++)
            {
                var input = Console.ReadLine();

                var countOfMatches = regex.Matches(input).Count;

                var currMessage = new StringBuilder();

                foreach (var letter in input)
                {
                    currMessage.Append((char)(letter - countOfMatches));
                }

                var pattern = @"\@(?<planet>[a-zA-Z]+)[^@\-!:>]*\:([0-9]+)[^@\-!:>]*\!(?<attack>A|D)\![^@\-!:>]*\-\>[0-9]+";

                var match = Regex.Match(currMessage.ToString(), pattern);

                if (match.Success)
                {
                    var planetName = match.Groups["planet"].Value;
                    var attackType = match.Groups["attack"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            PrintPlanetName(attackedPlanets);

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            PrintPlanetName(destroyedPlanets);
        }

        private static void PrintPlanetName(List<string> planets)
        {
            foreach (var planet in planets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
