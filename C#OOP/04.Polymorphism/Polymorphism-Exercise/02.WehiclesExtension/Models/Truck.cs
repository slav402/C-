using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double IncreasrConsuption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity, IncreasrConsuption)
        {
        }

        public override void Refuel(double liters)
        {
            if (liters + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            
            base.Refuel(liters * 0.95);
        }
    }
}
