using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            var usernames = Console.ReadLine().Split(", ");

            var validUsernames = new List<string> ();

            for (int i = 0; i < usernames.Length; i++)
            {
                string currWord = usernames[i];

                var length = currWord.Length;

                if (length < 3 || length > 16)
                    continue;

                bool isWordValid = true;

                for (int j = 0; j < currWord.Length; j++)
                {
                    if(!(char.IsLetterOrDigit(currWord[j]) || currWord[j] == '-' || currWord[j] == '_'))
                    {
                        isWordValid = false;
                        break;
                    }
                }

                if (isWordValid)
                {
                    validUsernames.Add(currWord);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }
    }
}
