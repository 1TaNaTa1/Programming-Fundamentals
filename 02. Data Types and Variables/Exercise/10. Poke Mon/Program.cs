using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());


            int startingPokePower = pokePower;
            int counter = 0;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                counter++;

                if (startingPokePower == pokePower * 2)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
