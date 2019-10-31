using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPointDistance = CalculateHypotenuse(x1, y1);
            double secondPointDistance = CalculateHypotenuse(x2, y2);

            if (firstPointDistance < secondPointDistance)
                Console.WriteLine($"({x1}, {y1})");
            else
                Console.WriteLine($"({x2}, {y2})");

        }

        static double CalculateHypotenuse(double a, double b)
        {
            return (a * a) + (b * b);
        }
    }
}
