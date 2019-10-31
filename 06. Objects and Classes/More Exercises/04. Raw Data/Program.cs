using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
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
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);

                cars.Add(car);
            }

            string neededType = Console.ReadLine();

            if(neededType == "fragile")
            {
                List<Car> resultList = cars
                    .Where(x => x.Cargo.Type == neededType && x.Cargo.Weight < 1000)
                    .ToList();

                foreach (Car car in resultList)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (neededType == "flamable")
            {
                List<Car> resultList = cars
                    .Where(x => x.Cargo.Type == neededType && x.Engine.Power > 250)
                    .ToList();

                foreach (Car car in resultList)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
