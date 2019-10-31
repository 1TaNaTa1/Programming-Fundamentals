using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            bool isInRange = IsSizeWhithinRange(password);
            bool isCharOrDigit = IsThereOnlyCharAndDigits(password);
            bool isTwoDigit = IsThereTwoDigits(password);

            if (isCharOrDigit && isTwoDigit && isInRange)
                Console.WriteLine("Password is valid");
        }

        static bool IsThereTwoDigits(string password)
        {
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                    count++;

                if (count == 2)
                {
                    return true;
                }
            }

            Console.WriteLine("Password must have at least 2 digits");
            return false;
        }

        static bool IsThereOnlyCharAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                bool isSymbolValid = (password[i] >= 'a' && password[i] <= 'z')
                    || (password[i] >= 'A' && password[i] <= 'Z')
                    || (password[i] >= '0' && password[i] <= '9');

                if (!isSymbolValid)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }

            return true;
        }

        static bool IsSizeWhithinRange(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
                return true;

            Console.WriteLine("Password must be between 6 and 10 characters");
            return false;
        }
    }
}
