using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                int result = GetMax(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstSymbol = char.Parse(Console.ReadLine());
                char secondSymbol = char.Parse(Console.ReadLine());

                char result = GetMax(firstSymbol, secondSymbol);

                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                string result = GetMax(firstString, secondString);

                Console.WriteLine(result);
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        static string GetMax(string a, string b)
        {

            int comparator = string.Compare(a, b);
            if (comparator == 1)
            {
                return a;
            }
            return b;
        }
    }
}
