using System;
using System.Linq;
using System.Collections;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            string[] arr = new string[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }

            int[] encryptedArr = new int[size];

            for (int i = 0; i < size; i++)
            {
                string vowels = "AaEeIiOoUu";
                string singleString = arr[i];

                int sum = 0;

                for (int j = 0; j < singleString.Length; j++)
                {
                    bool isVowel = false;

                    for (int k = 0; k < vowels.Length; k++)
                    {
                        if (singleString[j] == vowels[k])
                        {
                            isVowel = true;
                        }
                    }

                    if (isVowel)
                    {
                        sum += (int)singleString[j] * singleString.Length;
                    }
                    else
                    {
                        sum += (int)singleString[j] / singleString.Length;
                    }
                }

                encryptedArr[i] = sum;
            }

            Array.Sort(encryptedArr);
            Console.WriteLine(string.Join("\n", encryptedArr));
        }
    }
}
