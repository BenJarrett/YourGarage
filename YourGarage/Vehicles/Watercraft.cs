using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles
{
    class Watercraft : VehicleBase
    {

        public override void Refuel()
        {
            if (FuelCapacity <= 50)
            {
                FuelCapacity = +50;
            }
            Console.WriteLine($"Your watercraft is now at {FuelCapacity} %.");
        }

        public override void Driving()
        {
            Console.WriteLine($"The {Color} watercraft has set sail.");
        }

        public override void Landing()
        {
            Console.WriteLine($"The {Color} watercraft has been docked.");
        }
        
    }
}

