using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    public class VehicleCatalogue
    {
        public VehicleCatalogue()
        {
            this.Cars = new List<Vehicle>();
            this.Trucks = new List<Vehicle>();
        }

        public List<Vehicle> Cars { get; set; }

        public List<Vehicle> Trucks { get; set; }

        public string DisplayVehicle(List<Vehicle> list, string model)
        {
            Vehicle vehicle = list.Find(x => x.Model == model);

            string format = string.Format("Model: {0}{3}Color: {1}{3}Horsepower: {2}",
                vehicle.Model, 
                vehicle.Color, 
                vehicle.HorsePower, 
                Environment.NewLine);

            return format;
        }

        public double CalculateAverageHp(List<Vehicle> list)
        {
            if(list.Count == 0)
            {
                return 0;
            }

            int sum = list.Sum(x => x.HorsePower);

            double average = (double)sum / list.Count;

            return average;
        }
    }
}
