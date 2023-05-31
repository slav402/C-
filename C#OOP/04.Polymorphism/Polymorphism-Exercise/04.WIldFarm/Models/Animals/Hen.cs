using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        private const double HenWeightMultyplier = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultyplier
            => HenWeightMultyplier;

        public override IReadOnlyCollection<Type> PreferredFood
            => new HashSet<Type> { typeof(Meat), typeof(Fruit), typeof(Vegetable), typeof(Seeds) };

        public override string ProduceSound()
            => "Cluck";
    }
}
