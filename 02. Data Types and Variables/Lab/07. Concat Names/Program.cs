using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            string result = firstName + delimeter + secondName;

            Console.WriteLine(result);
        }
    }
}
