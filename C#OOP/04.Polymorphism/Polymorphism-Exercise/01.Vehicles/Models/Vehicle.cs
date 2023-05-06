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
            double currentFuelConsumption = FueluelConsumption + increaseConsumption;

            if (FuelQuantity < currentFuelConsumption * distance)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= currentFuelConsumption * distance;

            return $"Car/Truck travelled {distance} km";
        }

        public void Refuel(double liters)
            => FuelQuantity += liters;

        public override string ToString()
            => $"{this.GetType().Name}: {FuelQuantity:f2}";

    }
}
