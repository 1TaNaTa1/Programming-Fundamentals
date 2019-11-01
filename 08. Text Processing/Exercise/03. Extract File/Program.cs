using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main()
        {
            var filePath = Console.ReadLine();

            var indexOfSlash = filePath.LastIndexOf('\\') + 1;
            var indexOfDot = filePath.LastIndexOf('.') + 1;

            var fileName = filePath.Substring(indexOfSlash, indexOfDot - indexOfSlash - 1);
            var fileExtension = filePath.Substring(indexOfDot, filePath.Length - indexOfDot);

            Console.WriteLine("File name: {0}", fileName);
            Console.WriteLine("File extension: {0}", fileExtension);
        }
    }
}
