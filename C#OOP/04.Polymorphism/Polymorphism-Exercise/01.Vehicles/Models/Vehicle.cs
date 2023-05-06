using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {

        private double increaseConsumption;
        
        protected Vehicle(double fuelQuantity, double fuelConsumption, double increaseConsumption)
        {
            FuelQuantity = fuelQuantity;
            FueluelConsumption = fuelConsumption;
            this.increaseConsumption = increaseConsumption;
        }

        public double FuelQuantity { get; private set; }

        public double FueluelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double fuel
        }

        public void Refuel(double liters)
        {
            throw new NotImplementedException();
        }
    }
}
