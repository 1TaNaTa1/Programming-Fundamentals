using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main()
        {
            var key = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var input = Console.ReadLine();

            while(input != "find")
            {
                var message = input;

                var decryptedMessage = new StringBuilder();

                for (int i = 0; i < message.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        decryptedMessage.Append((char)(message[i] - key[j]));

                        i++;

                        if (i >= message.Length)
                        {
                            break;
                        }
                    }

                    i--;
                }

                message = decryptedMessage.ToString();

                var firstIndex = message.IndexOf('&') + 1;
                var lastIndex = message.LastIndexOf('&');

                var type = message.Substring(firstIndex, lastIndex - firstIndex);

                firstIndex = message.IndexOf('<') + 1;
                lastIndex = message.LastIndexOf('>');

                var coordinates = message.Substring(firstIndex, lastIndex - firstIndex);

                Console.WriteLine($"Found {type} at {coordinates}");

                input = Console.ReadLine();
            }
        }
    }
}
