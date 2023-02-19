using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] enter = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = enter[0];
                double fuelAmount = double.Parse(enter[1]);
                double fuelConsumptionFor1km = double.Parse(enter[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);

                cars.Add(currentCar);
            }

            string inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] token = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = token[1];
                double amountOfKm = double.Parse(token[2]);

                foreach (var car in cars)
                {
                    if (car.Model == carModel)
                    {
                        car.Drive(amountOfKm);
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
