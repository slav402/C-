﻿using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4] 
            {
                new Tire (1, 2.5),
                new Tire (1, 2.1),
                new Tire (2, 0.5),
                new Tire (2, 2.3),
            };

            var engine = new Engine(560, 6300);

            var car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);

            Console.WriteLine("Horse power: " + car.Engine.HorsePower);

            foreach (var tire in car.Tires)
            {
                Console.WriteLine($"{tire.Year} - {tire.Pressure}");
            }
        }
    }
}
