using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models
{
    public class Student : IStudent
    {
        private int id;

        public int Id
        {
            get { return Id; }
            private set { Id = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                firstName = value;
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                lastName = value;
            }
        }

        private IReadOnlyCollection<int> coveredExams;

        public IReadOnlyCollection<int> CoveredExams
        {
            get { return coveredExams; }
            set { coveredExams = value; }
        }


        public IUniversity University => throw new NotImplementedException();

        public void CoverExam(ISubject subject)
        {
            throw new NotImplementedException();
        }

        public void JoinUniversity(IUniversity university)
        {
            throw new NotImplementedException();
        }
    }
}
