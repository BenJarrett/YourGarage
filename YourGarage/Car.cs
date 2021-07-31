using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    class Car
    {
        public int BatteryCapacity { get; set; } = 50;
        public CarColor Color { get; set; }
        public string PassengerOccupancy { get; set; }


        public void Refuel()
        {
            if (BatteryCapacity <= 50)
            {
                BatteryCapacity = +50;
            }
            Console.WriteLine($"Your car is not at {BatteryCapacity} %.");
        }

        public void Driving()
        {
            Console.WriteLine($"The {Color} car is driving on the freeway.");
        }

        public void Braking()
        {
            Console.WriteLine($"The {Color} car braked at the red light.");
        }
        public enum CarColor
        {
            Black,
            Red,
            White,
            Blue
        }

    }
}
