using System;
using System.Collections.Generic;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = entry[0];
                int engineSpeed = int.Parse(entry[1]);
                int enginePower = int.Parse(entry[2]);
                int cargoWeight = int.Parse(entry[3]);
                string cargoType = entry[4];

                Engine engine = new Engine(engineSpeed, enginePower);

                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tire[] tires = new Tire[4]
                {
                    new Tire (double.Parse(entry[5]), int.Parse(entry[6])),
                    new Tire (double.Parse(entry[7]), int.Parse(entry[8])),
                    new Tire (double.Parse(entry[9]), int.Parse(entry[10])),
                    new Tire (double.Parse(entry[11]), int.Parse(entry[12])),
                };

                Car currentCar = new Car(model, engine, cargo, tires);

                carList.Add(currentCar);
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                foreach (var car in carList)
                {
                    if (car.Cargo.Type == "fragile")
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                Console.WriteLine(car.Model);
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var car in carList)
                {
                    if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
