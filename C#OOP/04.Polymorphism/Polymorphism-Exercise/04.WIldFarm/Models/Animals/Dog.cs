using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        private const double DogWeightMultyplier = 0.4;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMultyplier 
            => DogWeightMultyplier;

        public override IReadOnlyCollection<Type> PreferredFood 
            => new HashSet<Type> { typeof(Meat)};

        public override string ProduceSound()
            => "Woof!";

        public override string ToString()
        {
            return base.ToString() + $"{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
