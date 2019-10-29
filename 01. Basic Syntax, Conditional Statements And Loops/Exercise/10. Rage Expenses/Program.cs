using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceOfHeadset = double.Parse(Console.ReadLine());
            double priceOfMouse = double.Parse(Console.ReadLine());
            double priceOfKeyboard = double.Parse(Console.ReadLine());
            double priceOfDisplay = double.Parse(Console.ReadLine());

            double expenses;

            expenses = priceOfHeadset * (lostGames / 2);

            expenses += priceOfMouse * (lostGames / 3);

            expenses += priceOfKeyboard * (lostGames / 6);

            expenses += priceOfDisplay * (lostGames / 12);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
