using Raiding.Factories.Interfaces;
using Raiding.Models;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Factories
{
    public class HeroFactory : IBaseHeroFactories
    {
        public IBaseHero CreateHero(string type, string name)
        {
            switch (type)
            {
                case "Druid":
                    return new Druid(name, 80);
                case "Paladin":
                    return new Paladin(name, 100);
                case "Rogue":
                    return new Rogue(name, 80);
                case "Warrior":
                    return new Warrior(name, 100);
                default:
                    throw new ArgumentException("Invalid hero!"); ;
            }
        }
    }
}
