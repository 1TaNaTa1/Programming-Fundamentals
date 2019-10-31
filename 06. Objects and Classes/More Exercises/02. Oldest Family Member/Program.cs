using System;

namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main()
        {
            int numOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numOfPeople; i++)
            {
                string[] personData = Console.ReadLine().Split(' ');

                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine(oldestMember);
        }
    }
}
