using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, SortedDictionary<string, int[]>> dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

            int countOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfDragons; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string type = input[0];
                string name = input[1];

                int damage = 45;
                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }

                int health = 250;
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }

                int armor = 10;
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, int[]>();
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new int[3];
                }

                dragons[type][name][0] = damage;
                dragons[type][name][1] = health;
                dragons[type][name][2] = armor;
            }

            foreach (var type in dragons)
            {
                double averageDamage = type.Value.Select(x => x.Value[0]).Average();
                double averageHealth = type.Value.Select(x => x.Value[1]).Average();
                double averageArmor = type.Value.Select(x => x.Value[2]).Average();

                Console.WriteLine($"{type.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in type.Value)
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",
                        dragon.Key, dragon.Value[0], dragon.Value[1], dragon.Value[2]);
                }
            }
        }
    }
}
