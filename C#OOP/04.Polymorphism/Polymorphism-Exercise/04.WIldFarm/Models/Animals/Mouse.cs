using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        private const double MoueWeightMultyplier = 0.1;

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultyplier 
            => MoueWeightMultyplier;

        public override IReadOnlyCollection<Type> PreferredFood 
            => new HashSet<Type> { typeof(Vegetable), typeof(Fruit)};

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
