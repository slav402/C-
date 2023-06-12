using Raiding.Engine.Interfaces;
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

        private readonly ReadOnlyCollection<IBaseHero> riderSquad;


        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
