using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightMultyplier {get;}

        public abstract IReadOnlyCollection<Type> PreferredFood { get; }

        public abstract string ProduceSound();

        public void Eat(IFood food)
        {
            if (!PreferredFood.Any(pf => pf.Name == food.GetType().Name))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += food.Quantity * this.WeightMultyplier;

            this.FoodEaten += food.Quantity;
        }

    }
}
