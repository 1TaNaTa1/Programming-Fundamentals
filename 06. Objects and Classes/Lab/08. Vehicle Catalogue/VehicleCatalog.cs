using System.Collections.Generic;

namespace _08._Vehicle_Catalogue
{
    public class VehicleCatalog
    {
        public VehicleCatalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }
}
