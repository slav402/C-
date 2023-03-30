using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public decimal Salary => throw new NotImplementedException();
    }
}
