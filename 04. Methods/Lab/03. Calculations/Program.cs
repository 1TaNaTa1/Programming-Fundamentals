using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main()
        {
            string action = Console.ReadLine();

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (action == "add")
                Add(firstNumber, secondNumber);
            if (action == "subtract")
                Subtract(firstNumber, secondNumber);
            if (action == "multiply")
                Multiply(firstNumber, secondNumber);
            if (action == "divide")
                Divide(firstNumber, secondNumber);


        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}
