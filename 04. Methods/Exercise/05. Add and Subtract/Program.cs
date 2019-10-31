using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum);
            Substract(sum, thirdNum);

        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
