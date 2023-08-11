using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorReflection
{
    public class Product
    {
        public Product(int id, decimal price, string model)
        {
            Id = id;
            Price = price;
            Model = model;
        }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }
    }
}
