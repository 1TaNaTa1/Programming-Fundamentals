using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                ["fragments"] = 0,
                ["shards"] = 0,
                ["motes"] = 0
            };

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            string targetMaterial = string.Empty;

            while (true)
            {
                string[] materialsArgs = Console.ReadLine()
                    .ToLower()
                    .Split(' ');

                bool isQuantityReached = false;

                for (int i = 0; i < materialsArgs.Length; i += 2)
                {
                    int quantity = int.Parse(materialsArgs[i]);
                    string type = materialsArgs[i + 1];

                    if (type == "motes" || type == "shards" || type == "fragments")
                    {
                        keyMaterials[type] += quantity;

                        if (keyMaterials[type] >= 250)
                        {
                            targetMaterial += type;

                            keyMaterials[type] -= 250;

                            isQuantityReached = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(type))
                        {
                            junkMaterials[type] = 0;
                        }

                        junkMaterials[type] += quantity;
                    }
                }

                if (isQuantityReached)
                {
                    break;
                }
            }

            if (targetMaterial == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (targetMaterial == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (targetMaterial == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var kvp in keyMaterials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
