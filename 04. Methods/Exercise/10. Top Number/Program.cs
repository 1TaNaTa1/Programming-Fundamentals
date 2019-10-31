using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            PrintTopNumbers(num);
        }

        static void PrintTopNumbers(int n)
        {
            for (int i = 17; i <= n; i++)
            {
                int tempNum = i;
                bool isOdd = false;
                int sumOfDigits = 0;

                while (tempNum != 0)
                {
                    sumOfDigits += tempNum % 10;

                    if (isOdd == false)
                        if ((tempNum % 10) % 2 == 1)
                            isOdd = true;

                    tempNum /= 10;
                }

                if (sumOfDigits % 8 == 0 && isOdd == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
