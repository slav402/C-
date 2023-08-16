using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models
{
    public class University : IUniversity
    {
        private int id;

        public int Id
        {
            get { return Id; }
            private set { Id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }

        public string Category => throw new NotImplementedException();

        public int Capacity => throw new NotImplementedException();

        public IReadOnlyCollection<int> RequiredSubjects => throw new NotImplementedException();
    }
}
