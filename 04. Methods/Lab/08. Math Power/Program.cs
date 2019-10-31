using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        static double RaiseToPower(double num, int pow)
        {
            double result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}
