using MilitaryElite.Core;
using MilitaryElite.Core.Interfaces;
using MilitaryElite.Models;
using MilitaryElite.Models.Enums;
using System;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
