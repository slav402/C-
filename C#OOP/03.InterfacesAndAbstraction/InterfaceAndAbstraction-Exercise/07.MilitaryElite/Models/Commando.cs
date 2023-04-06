using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier
    {
        public Commando(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
        }
    }
}
