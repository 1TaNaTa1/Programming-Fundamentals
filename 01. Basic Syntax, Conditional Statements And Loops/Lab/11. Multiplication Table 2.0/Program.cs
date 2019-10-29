using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if ((multiplier / 11) == 0)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {i * num}");
                }
            }
            else
                Console.WriteLine($"{num} X {multiplier} = {multiplier * num}");
        }
    }
}
