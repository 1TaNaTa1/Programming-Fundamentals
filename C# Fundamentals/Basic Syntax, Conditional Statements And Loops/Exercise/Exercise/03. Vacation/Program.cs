using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main()
        {
            int numPeople = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();

            double totalPrice = 0;
            double pricePerPerson = 0;

            if (typePeople == "students")
            {
                if (dayOfWeek == "friday")
                    pricePerPerson = 8.45;
                else if (dayOfWeek == "saturday")
                    pricePerPerson = 9.80;
                else if (dayOfWeek == "sunday")
                    pricePerPerson = 10.46;

                totalPrice = pricePerPerson * numPeople;

                if (numPeople >= 30)
                    totalPrice -= (totalPrice * 0.15);
            }
            else if (typePeople == "business")
            {
                if (dayOfWeek == "friday")
                    pricePerPerson = 10.90;
                else if (dayOfWeek == "saturday")
                    pricePerPerson = 15.60;
                else if (dayOfWeek == "sunday")
                    pricePerPerson = 16;

                totalPrice = pricePerPerson * numPeople;

                if (numPeople >= 100)
                    totalPrice -= (pricePerPerson * 10);
            }
            else if (typePeople == "regular")
            {
                if (dayOfWeek == "friday")
                    pricePerPerson = 15;
                else if (dayOfWeek == "saturday")
                    pricePerPerson = 20;
                else if (dayOfWeek == "sunday")
                    pricePerPerson = 22.50;

                totalPrice = pricePerPerson * numPeople;

                if (numPeople >= 10 && numPeople <= 20)
                    totalPrice -= (totalPrice * 0.05);
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
