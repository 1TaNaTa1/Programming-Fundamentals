using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstResultArray = new string[n];
            string[] secondResultArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] tempArray = Console.ReadLine().Split();

                firstResultArray[i] = tempArray[i % 2];
                secondResultArray[i] = tempArray[(i + 1) % 2];
            }

            foreach (string item in firstResultArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (string item in secondResultArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
