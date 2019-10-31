using System;
using System.Linq;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main()
        {
            double[] coordinates = new double[8];

            for (int i = 0; i < 8; i++)
            {
                coordinates[i] = double.Parse(Console.ReadLine());
            }

            double firstLineLenght = CalculateDistance(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);
            double secondLineLenght = CalculateDistance(coordinates[4], coordinates[5], coordinates[6], coordinates[7]);

            if (firstLineLenght >= secondLineLenght)
            {
                double firstPointDistance = CalculateHypotenuse(coordinates[0], coordinates[1]);
                double secondPointDistance = CalculateHypotenuse(coordinates[2], coordinates[3]);

                if (firstPointDistance <= secondPointDistance)
                {
                    Console.WriteLine($"({coordinates[0]}, {coordinates[1]})({coordinates[2]}, {coordinates[3]})");
                }
                else
                {
                    Console.WriteLine($"({coordinates[2]}, {coordinates[3]})({coordinates[0]}, {coordinates[1]})");
                }
            }
            else
            {
                double firstPointDistance = CalculateHypotenuse(coordinates[4], coordinates[5]);
                double secondPointDistance = CalculateHypotenuse(coordinates[6], coordinates[7]);
                if (firstPointDistance <= secondPointDistance)
                {
                    Console.WriteLine($"({coordinates[4]}, {coordinates[5]})({coordinates[6]}, {coordinates[7]})");
                }
                else
                {
                    Console.WriteLine($"({coordinates[6]}, {coordinates[7]})({coordinates[4]}, {coordinates[5]})");
                }
            }
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distanceBetweenX = x1 - x2;
            double distanceBetweenY = y1 - y2;

            double distanceBetweenPoints = (distanceBetweenX * distanceBetweenX)
                                           + (distanceBetweenY * distanceBetweenY);

            return distanceBetweenPoints;
        }

        static double CalculateHypotenuse(double a, double b)
        {
            return (a * a) + (b * b);
        }
    }
}
