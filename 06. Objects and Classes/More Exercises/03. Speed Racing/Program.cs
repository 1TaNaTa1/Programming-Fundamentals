using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main()
        {
            int numOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ');

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(car);
            }

            string[] commandArgs = Console.ReadLine().Split(' ');

            while (commandArgs[0] != "End")
            {
                string model = commandArgs[1];
                double distance = double.Parse(commandArgs[2]);

                bool isFuelEnough = cars.Find(x => x.Model == model)
                    .IsFuelEnough(distance);

                if (!isFuelEnough)
                {
                    Console.WriteLine("Insufficient fuel for the drive") ;
                }

                commandArgs = Console.ReadLine().Split(' ');
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
