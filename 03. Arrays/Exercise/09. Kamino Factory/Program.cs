using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main()
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int[] dnaSequence = new int[dnaLenght];

            int maxCounter = 0;
            int finalIndex = -1;
            int inputCounter = 0;
            int bestDNACounter = 0;
            int sum = 0;

            while (input != "Clone them!")
            {
                int[] currDnaSequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                inputCounter++;

                int currCounter = 0;
                int currMaxCounter = 0;
                int currIndex = -1;

                for (int i = 0; i < currDnaSequence.Length; i++)
                {
                    if (currDnaSequence[i] == 1)
                    {
                        currCounter++;

                        if (currCounter > currMaxCounter)
                        {
                            currIndex = i - currCounter + 1;
                            currMaxCounter = currCounter;
                        }
                    }
                    else
                    {
                        currCounter = 0;
                    }
                }

                if (currMaxCounter > maxCounter)
                {
                    maxCounter = currMaxCounter;
                    finalIndex = currIndex;
                    dnaSequence = currDnaSequence;
                    bestDNACounter = inputCounter;
                    sum = dnaSequence.Sum();
                }
                else if (currMaxCounter == maxCounter)
                {
                    if (finalIndex > currIndex)
                    {
                        finalIndex = currIndex;
                        dnaSequence = currDnaSequence;
                        bestDNACounter = inputCounter;
                        sum = dnaSequence.Sum();
                    }
                    else if (finalIndex == currIndex)
                    {
                        int currSum = currDnaSequence.Sum();
                        sum = dnaSequence.Sum();

                        if (currSum > sum)
                        {
                            dnaSequence = currDnaSequence;
                            bestDNACounter = inputCounter;
                            sum = currSum;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if (bestDNACounter == 0)
            {
                bestDNACounter = 1;
            }
            Console.WriteLine($"Best DNA sample {bestDNACounter} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", dnaSequence));
        }
    }
}
