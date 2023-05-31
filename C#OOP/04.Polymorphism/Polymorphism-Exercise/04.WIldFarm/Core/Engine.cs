using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interfaces;
using WildFarm.IO.Interfaces;

namespace WildFarm.Core
{
    internal class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;



        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
