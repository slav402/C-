using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int MinValue = 1;
        private const int MaxValue = 15;

        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            PizzaName = name;
            Dough = dough;
            toppings = new List<Topping>();
        }

        public string PizzaName
        {
            get => name;
            private set
            {
                if (value.Length > MaxValue || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Pizza name should be between {MinValue} and {MaxValue} symbols.");
                }

                name = value;
            }
        }

        public Dough Dough
        {
            get => dough;
            set
            {
                dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            toppings.Add(topping);
        }

        public override string ToString()
        {
            double cal = toppings.Sum(t => t.GetToppingCalories()) + Dough.GetDoughCalories();

            return $"{PizzaName} - {cal:f2} Calories.";
        }
    }
}
