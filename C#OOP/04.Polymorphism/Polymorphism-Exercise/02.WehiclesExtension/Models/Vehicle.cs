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

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double increaseConsumption)
        {
            FuelQuantity = fuelQuantity;
            FueluelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            this.increaseConsumption = increaseConsumption;
        }

        public double FuelQuantity { get; private set; }

        public double FueluelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public string Drive(double distance, bool isIncreaseConsumption = true)
        {
            double currentFuelConsumption = isIncreaseConsumption
                ? FueluelConsumption + increaseConsumption 
                : FueluelConsumption;



            if (FuelQuantity < currentFuelConsumption * distance)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= currentFuelConsumption * distance;

            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            double totalFuelAmount = liters + FuelQuantity;

            if (totalFuelAmount > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters;
            }
        }


        public override string ToString()
            => $"{this.GetType().Name}: {FuelQuantity:f2}";

    }
}
