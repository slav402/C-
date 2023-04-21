using FoodShortage.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Citizen : IIdentifiable, IBirthdayable, IBuyer
    {
        private int food = 0;

        public Citizen(string name, string age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
            Food = food;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Id { get; private set; }

        public string Birthday { get; private set; }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
