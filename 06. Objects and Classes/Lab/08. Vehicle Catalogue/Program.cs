using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split('/')
                .ToArray();

            VehicleCatalog catalog = new VehicleCatalog();

            while (input[0] != "end")
            {
                string typeVehicle = input[0].ToLower();

                if (typeVehicle == "car")
                {
                    string brand = input[1];
                    string model = input[2];
                    string horsePower = input[3];

                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };

                    catalog.Cars.Add(car);
                }
                else if (typeVehicle == "truck")
                {
                    string brand = input[1];
                    string model = input[2];
                    string weight = input[3];

                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };

                    catalog.Trucks.Add(truck);
                }

                input = Console.ReadLine()
                    .Split('/')
                    .ToArray();
            }

            if (catalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");

                //Why the fuck it doesn't work
                //catalog.Cars.Sort((x, y) => { int isEqual = x.Brand.CompareTo(y.Brand);
                //    if (isEqual == 0)
                //        isEqual = (x.Model.CompareTo(y.Model));
                //    return isEqual;
                //});

                foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");

                // This also
                // catalog.Trucks.Sort((x, y) => x.Brand.CompareTo(y.Brand));

                foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
