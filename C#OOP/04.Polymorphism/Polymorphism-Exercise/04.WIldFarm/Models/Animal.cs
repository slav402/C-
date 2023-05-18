using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIldFarm.Models.Interfaces;

namespace WIldFarm.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name  { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public void Eat(IFood food)
        {
            throw new NotImplementedException();
        }

        public string ProduceSound()
        {
            throw new NotImplementedException();
        }
    }
}
