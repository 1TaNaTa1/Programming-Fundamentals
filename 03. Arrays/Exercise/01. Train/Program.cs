using System;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numberPeople = new int[n];

            for (int i = 0; i < n; i++)
            {
                numberPeople[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(numberPeople[i] + " ");
                sum += numberPeople[i];
            }

            Console.WriteLine("\n" + sum);
        }
    }
}
