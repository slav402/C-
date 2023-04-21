using FoodShortage.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Rebel : IGroupable, IBuyer
    {
        private int food = 0;

        public Rebel(string name, string age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = food;
        }

        public string Name { get; private set; }
        public string Age { get; private set; }
        public string Group { get; private set; }
        public int Food { get; set; }

        public void BuyFood()
        {
            Food +=5;
        }
    }
}
