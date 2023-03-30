using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber => throw new NotImplementedException();
    }
}
