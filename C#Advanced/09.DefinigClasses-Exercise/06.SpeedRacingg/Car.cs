using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TraveledDistance = 0;
        }

        public double TraveledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public void Drive (double distance)
        {
            if (this.FuelAmount - (distance * this.fuelConsumptionPerKilometer) < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= distance * this.fuelConsumptionPerKilometer;
                this.TraveledDistance += distance;
            }
        }


    }
}
