using System;
using System.Numerics;
using Telephony.Core;
using Telephony.Core.Interfaces;
using Telephony.IO;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(new ConsoleReader(), new ConsoleWriter());
            engine.Run();
            //engine.PrintSometing();
        }
    }
}
