using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var sum = 0;

            var firstWord = input[0];
            var secondWord = input[1];

            var leftWord = secondWord;
            var index = firstWord.Length;

            if(firstWord.Length > secondWord.Length)
            {
                leftWord = firstWord;
                index = secondWord.Length;
            }

            for (int i = 0; i < index; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            for (int i = index; i < leftWord.Length; i++)
            {
                sum += leftWord[i];
            }

            Console.WriteLine(sum);
        }
    }
}
