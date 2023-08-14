using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class UniversityRepository : IRepository<IUniversity>
    {
        public UniversityRepository()
        {
            models = new List<IUniversity>();
        }


        private List<IUniversity> models;

        public IReadOnlyCollection<IUniversity> Models
        {
            get { return models.AsReadOnly(); }
        }


        public void AddModel(IUniversity model)
        {
            models.Add(model);
        }

        public IUniversity FindById(int id)
        {
            return models.FirstOrDefault(x => x.Id == id); //FirstOrDefault връща обекта или null ако няма такъв
        }

        public IUniversity FindByName(string name)
        {
            return models.FirstOrDefault(x => x.Name == name);
        }
    }
}
