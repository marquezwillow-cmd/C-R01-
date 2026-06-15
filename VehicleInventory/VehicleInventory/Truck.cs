using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    namespace VehicleInventory
    {
        // 5.1.	Add the following class for Truck that also overrides Vehicle:
        public class Truck : Vehicle
        {
            public Truck(string vin, string license)
            {
                VIN = vin;
                LicensePlate = license;
            }

            private int wheels = 4;
            public override int Wheels => wheels;
            public override int MaxPassengers => 3;

            public override string ToString()
            {
                return "Truck License Plate: " + LicensePlate + " VIN " + VIN;
            }

            public override string GetDescription()
            {
                return "Truck License Plate: " + LicensePlate + " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers;
            }
        }
    }
}
