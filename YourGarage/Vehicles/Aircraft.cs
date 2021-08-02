using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles
{
    class Aircraft : VehicleBase
    {
        public override void Refuel()
        {
            if (FuelCapacity <= 50)
            {
                FuelCapacity = +50;
            }
            Console.WriteLine($"Your aircraft is now at {FuelCapacity} %.");
        }

        public override void Driving()
        {
            Console.WriteLine($"The {Color} aircraft is flying freely in the sky.");
        }

        public override void Landing()
        {
            Console.WriteLine($"The {Color} aircraft landed on the runway.");
        }
    }
}
