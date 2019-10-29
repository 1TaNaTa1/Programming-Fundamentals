using System;

namespace _05._Login
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = 0; i < username.Length; i++)
            {
                password += username[username.Length - i - 1];
            }

            bool isLogged = false;
            for (int i = 0; i <= 3; i++)
            {
                string tryPassword = Console.ReadLine();
                if (tryPassword == password)
                {
                    isLogged = true;
                    Console.WriteLine("User {0} logged in.", username);
                    break;
                }
                if (i == 3)
                    break;
                Console.WriteLine("Incorrect password. Try again.");
            }

            if (isLogged == false)
                Console.WriteLine("User {0} blocked!", username);

        }
    }
}
