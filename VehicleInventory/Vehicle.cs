using System;

namespace VehicleInventory
{
    //3.1.	Create an abstract class that represents the common attributes of our vehicles:
   {
    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string LicensePlate { get; set; }
        public abstract int Wheels { get; }
        public abstract int MaxPassengers { get; }
        public abstract string GetDescription();
    }
}
