using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    internal class Warrior : BaseHero
    {
        public Warrior(string name, int power) 
            : base(name, power)
        {
        }

        public override string CastAbility()
        => $"{this.GetType().Name} - {Name} hit for {Power} damage";
    }
}
