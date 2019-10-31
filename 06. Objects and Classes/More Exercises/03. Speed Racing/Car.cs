namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumedPerKm = fuelConsumptionPerKm;

            this.TraveledDistance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumedPerKm { get; set; }

        public double TraveledDistance { get; set; }

        public bool IsFuelEnough(double distance)
        {
            double neededFuel = this.FuelConsumedPerKm * distance;

            if(neededFuel > this.FuelAmount)
            {
                return false;
            }

            this.FuelAmount -= neededFuel;
            this.TraveledDistance += distance;

            return true;
        }
    }
}
