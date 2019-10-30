using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] field = new int[size];

            int[] bugsPositions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < bugsPositions.Length; i++)
            {
                if (bugsPositions[i] < 0 || bugsPositions[i] >= size)
                {
                    continue;
                }
                field[bugsPositions[i]] = 1;
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                int initialPosition = int.Parse(command[0]);
                int flyLength = int.Parse(command[2]);

                string direction = command[1];

                if (!(initialPosition >= size || initialPosition < 0 || field[initialPosition] != 1))
                {
                    int targetPosition = initialPosition;

                    field[initialPosition] = 0;

                    if (direction == "right")
                    {
                        targetPosition += flyLength;

                        while (targetPosition < size && field[targetPosition] == 1)
                        {
                            targetPosition += flyLength;
                        }

                        if (targetPosition < size)
                        {
                            field[targetPosition] = 1;
                        }
                    }
                    else if (direction == "left")
                    {
                        targetPosition -= flyLength;

                        while (targetPosition >= 0 && field[targetPosition] == 1)
                        {
                            targetPosition -= flyLength;
                        }

                        if (targetPosition >= 0)
                        {
                            field[targetPosition] = 1;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
