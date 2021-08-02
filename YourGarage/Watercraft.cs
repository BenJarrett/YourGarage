using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    class Watercraft
    {
        public int FuelCapacity { get; set; } = 50;
        public WatercraftColor Color { get; set; }
        public string PassengerOccupancy { get; set; }


        public void Refuel()
        {
            if (FuelCapacity <= 50)
            {
                FuelCapacity = +50;
            }
            Console.WriteLine($"Your watercraft is now at {FuelCapacity} %.");
        }

        public void Driving()
        {
            Console.WriteLine($"The {Color} watercraft has set sail.");
        }

        public void Landing()
        {
            Console.WriteLine($"The {Color} watercraft has been docked.");
        }
        public enum WatercraftColor
        {
            Black,
            Red,
            White,
            Blue
        }
    }
}
}
