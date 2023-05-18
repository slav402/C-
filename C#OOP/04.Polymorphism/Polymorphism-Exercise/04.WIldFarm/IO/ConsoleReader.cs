using System;
using WIldFarm.IO.Interfaces;

namespace WIldFarm.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() 
            => Console.ReadLine();
    }
}
