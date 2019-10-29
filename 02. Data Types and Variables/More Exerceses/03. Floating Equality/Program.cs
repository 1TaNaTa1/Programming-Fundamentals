using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double difference = Math.Abs(firstNumber - secondNumber);

            if (difference > 0.000001)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }

        }
    }
}
