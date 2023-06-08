using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models;

namespace Vecicles.Models
{
    public class Bus : Vehicle
    {
        private const double IncreasrConsuption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity, double increaseConsumption) 
            : base(fuelQuantity, fuelConsumption, tankCapacity, IncreasrConsuption)
        {
        }
    }
}
