using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class StudentRepository : IRepository<IStudent>
    {
        public StudentRepository()
        {
            models = new List<IStudent>();
        }


        private List<IStudent> models;

        public IReadOnlyCollection<IStudent> Models
        {
            get { return models.AsReadOnly(); }
        }


        public void AddModel(IStudent model)
        {
            models.Add(model);
        }

        public IStudent FindById(int id)
        {
            return models.FirstOrDefault(x => x.Id == id); //FirstOrDefault връща обекта или null ако няма такъв
        }

        public IStudent FindByName(string name)
        {
            string[] splited = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = splited[0];
            string lastName = splited[1];


            return models.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
