using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int MinGrams = 1;
        private const int MaxGrams = 200;

        private string doughType;
        private string technique;
        private int grams;

        public Dough(string type, string technique, int grams)
        {
            DoughType = type;
            Technique = technique;
            Grams = grams;
        }

        public int Grams
        {
            get => grams;
            private set
            {
                if (value < MinGrams || value > MaxGrams)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinGrams}..{MaxGrams}].");
                }
                grams = value;
            }
        }

        public string Technique
        {
            get => technique;
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                technique = value;
            }
        }

        public string DoughType
        {
            get => doughType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                doughType = value;
            }
        }

        public double GetDoughCalories()
        {
            double doughModifier = 0;
            double techniqueModifier = 0;

            switch (DoughType.ToLower())
            {
                case "white":
                    doughModifier = 1.5;
                    break;

                case "wholegrain":
                    doughModifier = 1.0;
                    break;
            }

            switch (Technique.ToLower())
            {
                case "crispy":
                    techniqueModifier = 0.9;
                    break;
                case "chewy":
                    techniqueModifier = 1.1;
                    break;
                case "homemade":
                    techniqueModifier = 1.0;
                    break;
            }

            return Grams * 2 * doughModifier * techniqueModifier;
        }
    }
}
