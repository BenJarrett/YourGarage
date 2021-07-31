using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    class Aircraft
    {
        public int FuelCapacity { get; set; } = 50;
        public AircraftColor Color { get; set; }
        public string PassengerOccupancy { get; set; }


        public void Refuel()
        {
            if (FuelCapacity <= 50)
            {
                FuelCapacity = +50;
            }
            Console.WriteLine($"Your aircraft is not at {FuelCapacity} %.");
        }

        public void Driving()
        {
            Console.WriteLine($"The {Color} aircraft is flying freely in the sky.");
        }

        public void Landing()
        {
            Console.WriteLine($"The {Color} landed on the runway.");
        }
        public enum AircraftColor
        {
            Black,
            Red,
            White,
            Blue
        }
    }
}
