using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string firstElement = array[i];

                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = firstElement;
            }

            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
