using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool isOpened = false;
            bool isBalanced = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (!isOpened)
                    {
                        isOpened = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
                else if (input == ")")
                {
                    if (isOpened)
                    {
                        isOpened = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }

            if (isBalanced && !isOpened)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
