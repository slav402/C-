using BorederControl.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BorederControl.Models
{
    public class Citizen : IIdentifiable, IBirthdayable
    {
        public Citizen(string name, string age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public string Name { get; private set; }
        public string Age { get; private set; }
        public string Id { get; private set; }
        public string Birthday { get; private set; }
    }
}
