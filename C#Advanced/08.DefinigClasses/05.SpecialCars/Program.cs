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
            List<Car> car = new List<Car>();

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


            }

        }
    }
}
