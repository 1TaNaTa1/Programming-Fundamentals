using System;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            VehicleCatalogue catalogue = new VehicleCatalogue();

            while (input[0] != "End")
            {
                string vehicleType = input[0];
                string model = input[1];
                string color = input[2];
                int horsePower = int.Parse(input[3]);

                Vehicle vehicle = new Vehicle(model, color, horsePower);

                if (vehicleType == "car")
                {
                    catalogue.Cars.Add(vehicle);
                }
                else if (vehicleType == "truck")
                {
                    catalogue.Trucks.Add(vehicle);
                }

                input = Console.ReadLine().Split(' ');
            }

            string command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                if (catalogue.Cars.Exists(x => x.Model == command))
                {
                    Console.WriteLine("Type: Car");

                    Console.WriteLine(catalogue.DisplayVehicle(catalogue.Cars, command));
                }
                else if (catalogue.Trucks.Exists(x => x.Model == command))
                {
                    Console.WriteLine("Type: Truck");

                    Console.WriteLine(catalogue.DisplayVehicle(catalogue.Trucks, command));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Cars have average horsepower of: {0:f2}.",
                catalogue.CalculateAverageHp(catalogue.Cars));

            Console.WriteLine("Trucks have average horsepower of: {0:f2}.",
                catalogue.CalculateAverageHp(catalogue.Trucks));
        }
    }
}
