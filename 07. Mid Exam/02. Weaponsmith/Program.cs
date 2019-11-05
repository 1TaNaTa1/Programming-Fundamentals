using System;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main()
        {
            string[] particles = Console.ReadLine().Split("|");

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] splitedCommand = command.Split();

                if (splitedCommand[0] == "Move")
                {
                    if (splitedCommand[1] == "Left")
                    {
                        int index = int.Parse(splitedCommand[2]);

                        if (index - 1 < particles.Length && index >= 1)
                        {
                            string oldParticle = particles[index];
                            particles[index] = particles[index - 1];
                            particles[index - 1] = oldParticle;
                        }
                        
                    }
                    else if (splitedCommand[1] == "Right")
                    {
                        int index = int.Parse(splitedCommand[2]);

                        if (index + 1 < particles.Length && index >= 0)
                        {
                            string oldParticle = particles[index];
                            particles[index] = particles[index + 1];
                            particles[index + 1] = oldParticle;
                        }
                    }
                }
                else if (splitedCommand[0] == "Check")
                {
                    if (splitedCommand[1] == "Even")
                    {
                        for (int i = 0; i < particles.Length; i += 2)
                        {
                            Console.Write(particles[i] + " ");
                        }
                        Console.WriteLine();
                    }
                    if (splitedCommand[1] == "Odd")
                    {
                        for (int i = 1; i < particles.Length; i += 2)
                        {
                            Console.Write(particles[i] + " ");
                        }
                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", particles)}!"
);
        }
    }
}
