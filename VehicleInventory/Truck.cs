using System;

namespace VehicleInventory
{
    5.1.	Add the following class for Truck that also overrides Vehicle:
public class Truck : Vehicle
    {
        public Truck(string vin, string license)
        {
            VIN = vin;
            LicensePlate = license;
        }

        private int wheels = 4;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 3;
            }
        }

        public override string ToString()
        {
            return "Truck License Plate: " + LicensePlate +
                " VIN " + VIN;
        }

        public override string GetDescription()
        {
            return "Truck License Plate: " + LicensePlate +
                " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers; ;
        }
    }

}