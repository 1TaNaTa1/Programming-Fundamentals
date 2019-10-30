using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            
            // Waste too much memory 
            // Need to fix
            long[,] array = new long[sizeOfArray, sizeOfArray];

            array[0, 0] = 1;
            for (int i = 1; i < sizeOfArray; i++)
            {
                array[i, 0] = 1;

                for (int j = 1; j <= i; j++)
                {
                    array[i, j] = array[i - 1, j - 1] + array[i - 1, j];


                }
            }

            for (int i = 0; i < sizeOfArray; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
