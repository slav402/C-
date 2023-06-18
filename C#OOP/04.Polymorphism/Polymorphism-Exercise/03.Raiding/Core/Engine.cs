using Raiding.Engine.Interfaces;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Engine
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private readonly ICollection<IBaseHero> riderSquad;
        private IBaseHeroFactories baseHeroFactories;

        public Engine(IReader reader, IWriter writer, IBaseHeroFactories baseHeroFactories)
        {
            this.reader = reader;
            this.writer = writer;
            this.baseHeroFactories = baseHeroFactories;

            riderSquad = new List<IBaseHero>();
        }

        public void Run()
        {
            int squadNum = int.Parse(reader.ReadLine());

            for (int i = 0; i < squadNum; i++)
            {
                string heroType = reader.ReadLine();
                string heroName = reader.ReadLine();

                try
                {
                    IBaseHero currentHero = baseHeroFactories.CreateHero(heroName, heroType);
                    riderSquad.Add(currentHero);
;
                }
                catch (ArgumentException ex)
                {
                    i--;
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            int bossPower = int.Parse(reader.ReadLine());

            int squadPower = 0;

            foreach (var hero in riderSquad)
            {
                writer.WriteLine(hero.CastAbility());
                squadPower += hero.Power;
            }

            if (bossPower > squadPower)
            {
                writer.WriteLine("Defeat...");
            }
            else
            {
                writer.WriteLine("Victory!");
            }
        }

    }
}
