using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i, i * num);
            }
        }
    }
}
