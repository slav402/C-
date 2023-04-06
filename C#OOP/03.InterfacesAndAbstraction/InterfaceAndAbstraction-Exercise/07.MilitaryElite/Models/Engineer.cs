using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier
    {
        public Engineer(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
        }
    }
}
