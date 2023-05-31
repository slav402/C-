﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factotiess.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factotiess
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] tokens)
        {
            string type = tokens[0];
            string name = tokens[1];
            double weight = double.Parse(tokens[2]);

            switch (type)
            {
                case "Owl":
                    return new Owl(name, weight, double.Parse(tokens[3]));
                case "Hen":
                    return new Hen(name, weight, double.Parse(tokens[3]));
                case "Mouse":
                    return new Mouse(name, weight, tokens[3]);
                case "Dog":
                    return new Dog(name, weight, tokens[3]);
                case "Cat":
                    return new Cat(name, weight, tokens[3]);
                case "Tiger":
                    return new Tiger(name, weight, tokens[3]);
                default:
                    throw new ArgumentException("Invalid type of animal!");
            }
        }
    }
}
