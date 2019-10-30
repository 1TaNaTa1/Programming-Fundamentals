using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        Console.Write(firstArray[i] + " ");
                    }

                }
            }
        }
    }
}
