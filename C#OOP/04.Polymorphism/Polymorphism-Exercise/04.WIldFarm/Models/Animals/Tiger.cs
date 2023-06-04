﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double TigerWeightMultyplier = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override IReadOnlyCollection<Type> PreferredFood 
            => new HashSet<Type> { typeof(Meat)};

        protected override double WeightMultyplier 
            => TigerWeightMultyplier;

        public override string ProduceSound()
            => "ROAR!!!";
    }
}
