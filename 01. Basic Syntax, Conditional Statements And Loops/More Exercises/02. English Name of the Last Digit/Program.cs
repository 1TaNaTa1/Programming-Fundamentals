using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string[] numAsText = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Console.WriteLine(numAsText[number % 10]);
        }
    }
}
