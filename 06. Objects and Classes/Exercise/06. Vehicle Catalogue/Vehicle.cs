namespace _06._Vehicle_Catalogue
{
    public class Vehicle
    {
        public Vehicle(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}
