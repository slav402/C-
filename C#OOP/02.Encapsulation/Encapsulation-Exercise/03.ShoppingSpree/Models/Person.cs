using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }


        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public void AddProdduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                throw new ArgumentException($"{ this.Name } can't afford {product.Name}");
            }

            bag.Add(product);
            this.Money -= product.Cost;
        }

        public override string ToString()
        {
            string boughtProducts = bag.Any()
                ? string.Join(", ", this.bag.Select(p => p.Name))
                : "Nothing bought";

            return $"{Name} - {boughtProducts}";

            //if (this.bag.Count == 0)
            //{
            //    return $"{this.Name} - Nothing bought";
            //}

            //return $"{this.Name} - {string.Join(", ", this.bag.Select(p => p.Name))}";
        }

    }
}
