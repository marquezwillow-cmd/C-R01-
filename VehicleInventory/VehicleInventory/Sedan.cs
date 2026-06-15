using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleInventory
{
    //4.3.	Add the following code:
    public class Sedan : Vehicle
    {
        private int wheels = 4;
        public override int Wheels => wheels;
        public override int MaxPassengers => 5;

        public override string GetDescription()
        {
            return "Sedan License Plate: " + LicensePlate + " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers;
        }
        //4.4.	Let’s also override ToString:

        public override string ToString()
        {
            return "Sedan License Plate: " + LicensePlate + " VIN " + VIN;
        }
    }

}
