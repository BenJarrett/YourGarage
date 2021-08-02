using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles
{
    class VehicleBase
    {
        public VehicleColor Color { get; set; }



        public virtual void Refuel()
        {
            Console.WriteLine("Default Refuel");
        }

        public virtual void Driving()
        {
            Console.WriteLine("Default Driving");
        }

        public virtual void Landing()
        {
            Console.WriteLine("Default Landing");
        }

        public virtual void Braking()
        {
            Console.WriteLine("Default Breaking");
        }
    }
}
