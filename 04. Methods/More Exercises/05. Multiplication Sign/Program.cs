using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            if (numbers[0] == 0 || numbers[1] == 0 || numbers[2] == 0)
            {
                Console.WriteLine("zero");
                return;
            }

            int negativeSignCounter = 0;

            for (int i = 0; i < 3; i++)
            {
                negativeSignCounter += Sign(numbers[i]);
            }

            if (negativeSignCounter % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }

        static int Sign(int num)
        {
            if (num > 0)
            {
                return 0;
            }

            return 1;
        }
    }
}
