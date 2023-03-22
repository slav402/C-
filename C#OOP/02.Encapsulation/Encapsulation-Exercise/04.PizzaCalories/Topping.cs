using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int MinGrams = 1;
        private const int MaxGrams = 50;

        private string toppingType;
        private int grams;

        public Topping(string toppingType, int grams)
        {
            ToppingType = toppingType;
            Grams = grams;
        }

        public int Grams
        {
            get => grams;
            private set
            {
                if (value < MinGrams || value > MaxGrams)
                {
                    throw new ArgumentException($"{ToppingType} weight should be in the range [{MinGrams}..{MaxGrams}].");
                }
                grams = value;
            }
        }

        public string ToppingType
        {
            get => toppingType;
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value;
            }
        }

        public double GetToppingCalories()
        {
            double toppingModifier = 0;

            if (ToppingType.ToLower() == "meat")
            {
                toppingModifier = 1.2;
            }
            else if (ToppingType.ToLower() == "veggies")
            {
                toppingModifier = 0.8;
            }
            else if (ToppingType.ToLower() == "cheese")
            {
                toppingModifier = 1.1;
            }
            else
            {
                toppingModifier = 0.9;
            }

            return Grams * 2 * toppingModifier;
        }
    }
}
