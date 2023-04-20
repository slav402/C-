using BorederControl.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorederControl.Models
{
    public class Pet : IBirthdayable
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; private set; }
        public string Birthday { get; private set; }
    }
}
