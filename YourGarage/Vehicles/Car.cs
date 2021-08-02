using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles
{
    class Car : VehicleBase
    {
        public int FuelCapacity { get; set; } = 50;
        public string PassengerOccupancy { get; set; }


        public override void Refuel()
        {
            if (FuelCapacity <= 50)
            {
                FuelCapacity = +50;
            }
            Console.WriteLine($"Your car is now at {FuelCapacity} %.");
        }

        public override void Driving()
        {
            Console.WriteLine($"The {Color} car is driving on the freeway.");
        }

        public override void Braking()
        {
            Console.WriteLine($"The {Color} car braked at the red light.");
        }

    }
}
