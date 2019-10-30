using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string firstElement = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = firstElement;
            }

            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
