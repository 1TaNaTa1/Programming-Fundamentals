using System;

namespace _01._Sort_Numbers
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

            for (int i = 0; i < 2; i++)
            {
                bool isSwaped = false;

                for (int j = 0; j < 3 - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int firstNum = numbers[j];

                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = firstNum;

                        isSwaped = true;
                    }
                }

                if (isSwaped == false)
                {
                    break;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
