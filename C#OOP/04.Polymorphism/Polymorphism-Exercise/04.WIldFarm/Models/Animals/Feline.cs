using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIldFarm.Models.Interfaces;

namespace WIldFarm.Models.Animals
{
    public abstract class Feline : Animal, IFeline
    {
        protected Feline(string name, double weight, string breed) 
            : base(name, weight)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }
    }
}
