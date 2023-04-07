using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary) : base(id,
                                                                                          firstName,
                                                                                          lastName,
                                                                                          salary)
        {
        }

        public IReadOnlyCollection<IMission> Missions => throw new NotImplementedException();
    }
}
