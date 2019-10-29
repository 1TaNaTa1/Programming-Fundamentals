using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main()
        {
            int numberPeople = int.Parse(Console.ReadLine());

            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesCounter = (int)Math.Ceiling((double)numberPeople / elevatorCapacity);

            Console.WriteLine(coursesCounter);
        }
    }
}
