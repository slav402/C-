using MilitaryElite.Models;
using MilitaryElite.Models.Enums;
using System;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Private currentPrivate = new Private(1, "Bibi", "Kokov", 100);

            Console.WriteLine(currentPrivate.ToString());
        }
    }
}
