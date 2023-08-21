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
        public University(int universityId, string universityName, string category, int capacity, ICollection<int> requiredSubjects
)
        {
            Id = universityId;
            Name = universityName;
            Category = category;
            Capacity = capacity;
            this.requaredSubject = requiredSubjects.ToList();
        }

        private string[] allowedCategories = new string[] { "Technical", "Economical", "Humanity" };

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

        private string category;

        public string Category
        {
            get { return category; }
            set

            {
                if (allowedCategories.Contains(value))
                {
                    category = value;
                }

                throw new ArgumentException(String.Format(ExceptionMessages.CategoryNotAllowed, value));
            }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            private set 
            {
                if (capacity < 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityNegative);
                }

                capacity = value; 
            }
        }

        private List<int> requaredSubject;

        public IReadOnlyCollection<int> RequiredSubjects
        {
            get { return requaredSubject.AsReadOnly(); } 
        }
    }
}
