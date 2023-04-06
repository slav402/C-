using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName) : base(id, firstName, lastName)
        {
        }

        public int CodeNumber => throw new NotImplementedException();
    }
}
