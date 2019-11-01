using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main()
        {
            var enlishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var morseAlphabet = new List<string>
            {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.",
                "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };

            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == "|")
                {
                    result.Append(' ');
                    continue;
                }

                var index = morseAlphabet.IndexOf(input[i]);

                result.Append(enlishAlphabet[index]);
            }

            Console.WriteLine(result);
        }
    }
}
