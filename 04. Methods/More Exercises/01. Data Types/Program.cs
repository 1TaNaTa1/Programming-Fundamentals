using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int num = int.Parse(Console.ReadLine());

                ManipulateData(num);
            }
            else if (type == "real")
            {
                double num = double.Parse(Console.ReadLine());

                ManipulateData(num);
            }
            else if (type == "string")
            {
                string text = Console.ReadLine();

                ManipulateData(text);
            }
        }

        static void ManipulateData(int num)
        {
            Console.WriteLine(num * 2);
        }

        static void ManipulateData(double num)
        {
            Console.WriteLine($"{(num * 1.5):f2}");
        }

        static void ManipulateData(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}
