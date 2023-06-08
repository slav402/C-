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
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double increaseConsumption)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FueluelConsumption = fuelConsumption;
            this.increaseConsumption = increaseConsumption;
        }

        public double FuelQuantity 
        { 
            get => fuelQuantity; 
            private set
            {
                if (TankCapacity < value )
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

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
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (liters + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            
            FuelQuantity += liters;
        }


        public override string ToString()
            => $"{this.GetType().Name}: {FuelQuantity:f2}";

    }
}
