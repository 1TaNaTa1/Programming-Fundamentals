using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            string message = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                symbol = (char)((int)symbol + key);

                message += symbol;
            }

            Console.WriteLine(message);
        }
    }
}
