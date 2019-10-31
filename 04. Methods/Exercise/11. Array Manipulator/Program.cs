using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] == "exchange")
                {
                    Exchange(array, command);
                }
                else if (command[0] == "max")
                {
                    int index = Max(array, command);
                    if (index != -1)
                        Console.WriteLine(index);
                    else
                        Console.WriteLine("No matches");
                }
                else if (command[0] == "min")
                {
                    int index = Min(array, command);
                    if (index != -1)
                        Console.WriteLine(index);
                    else
                        Console.WriteLine("No matches");
                }
                else if (command[0] == "first")
                {
                    PrintFirstFound(array, command);
                }
                else if (command[0] == "last")
                {
                    PrintLastFound(array, command);
                }
                else if (command[0] == "end")
                {
                    break;
                }

                command = Console.ReadLine().Split();
            }


            Console.Write("[");
            Console.Write(string.Join(", ", array));
            Console.WriteLine("]");

        }

        static void Exchange(int[] arr, string[] command)
        {
            int index = int.Parse(command[1]);

            if (index > arr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            int[] firstArr = new int[index + 1];
            int[] secondArr = new int[arr.Length - (index + 1)];


            for (int i = 0; i <= index; i++)
            {
                firstArr[i] = arr[i];
            }

            for (int j = 0, i = index + 1; i < arr.Length; i++, j++)
            {
                secondArr[j] = arr[i];
            }

            secondArr.CopyTo(arr, 0);
            firstArr.CopyTo(arr, secondArr.Length);
        }

        static int Max(int[] arr, string[] command)
        {
            int index = -1;

            int max = int.MinValue;

            if (command[1] == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] > max)
                        {
                            max = arr[i];
                            index = i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 1)
                    {
                        if (arr[i] > max)
                        {
                            max = arr[i];
                            index = i;
                        }
                    }
                }
            }

            return index;
        }

        static int Min(int[] arr, string[] command)
        {
            int index = -1;

            int min = int.MaxValue;

            if (command[1] == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] < min)
                        {
                            min = arr[i];
                            index = i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 1)
                    {
                        if (arr[i] < min)
                        {
                            min = arr[i];
                            index = i;
                        }
                    }
                }
            }

            return index;
        }

        // TO FIX
        static void PrintFirstFound(int[] arr, string[] command)
        {
            int count = int.Parse(command[1]);

            string numbersText = string.Empty;

            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int tempCount = count;

            Console.Write("[");

            if (command[2] == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        numbersText += arr[i] + " ";
                        tempCount--;
                    }

                    if (tempCount == 0)
                    {
                        break;
                    }
                }
            }
            else if (command[2] == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 1)
                    {
                        numbersText += arr[i] + " ";
                        tempCount--;
                    }

                    if (tempCount == 0)
                    {
                        break;
                    }
                }
            }

            string[] result = new string[count];

            for (int i = 0, j = 0; i < numbersText.Length - 1; j++, i += 2)
            {
                result[j] = numbersText[i].ToString();
            }

            Console.Write(string.Join(", ", result));
            Console.WriteLine("]");
        }

        // TO FIX
        static void PrintLastFound(int[] arr, string[] command)
        {
            int count = int.Parse(command[1]);

            string numbersText = string.Empty;

            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int tempCount = count;

            Console.Write("[");

            if (command[2] == "even")
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        numbersText += arr[i] + " ";
                        tempCount--;
                    }

                    if (tempCount == 0)
                    {
                        break;
                    }
                }
            }
            else if (command[2] == "odd")
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 1)
                    {
                        numbersText += arr[i] + " ";
                        tempCount--;
                    }

                    if (tempCount == 0)
                    {
                        break;
                    }
                }
            }

            string[] result = new string[count];

            for (int i = 0, j = 0; i < numbersText.Length - 1; j++, i += 2)
            {
                result[j] = numbersText[i].ToString();
            }

            Console.Write(string.Join(", ", result));
            Console.WriteLine("]");
        }
    }
}
