using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            List<Engine> enginesList = new List<Engine>();
            List<Car> carList = new List<Car>();

            string entry = string.Empty;

            while ((entry = Console.ReadLine()) != "No more tires")
            {
                double[] tiresInput = entry.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                Tire[] tires = new Tire[4] 
                {
                    new Tire ((int)tiresInput[0], tiresInput[1]),
                    new Tire ((int)tiresInput[2], tiresInput[3]),
                    new Tire ((int)tiresInput[4], tiresInput[5]),
                    new Tire ((int)tiresInput[6], tiresInput[7]),
                };

                tiresList.Add(tires);
            }

            while ((entry = Console.ReadLine()) != "Engines done")
            {
                double[] enginesData = entry.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                Engine engine = new Engine((int)enginesData[0], enginesData[1]);

                enginesList.Add(engine);
            }

            while ((entry = Console.ReadLine()) != "Show special")
            {
                //Audi A5 2017 200 12 0 0
                string[] car = entry.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string make = car[0];
                string model = car[1];
                int year = int.Parse(car[2]);
                double fuelQuantity = double.Parse(car[3]);
                double fuelConsumtion = double.Parse(car[4]);
                int tireIndex = int.Parse(car[5]);
                int engineIndex = int.Parse(car[6]);

                Car curentCar = new Car(make, model, year, fuelQuantity, fuelConsumtion, enginesList[engineIndex], tiresList[tireIndex]);

                carList.Add(curentCar);
            }

            List<Car> specialCars = new List<Car>();

            foreach (var car in carList)
            {
                double presure = car.Tires.Sum(p => p.Pressure);

                if (presure > 9 && presure < 10)
                {
                    if (car.Year >= 2017 && car.Engine.HorsePower >= 330)
                    {
                        car.Drive(20);

                        specialCars.Add(car);
                    }
                }
            }

            foreach (var car in specialCars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
