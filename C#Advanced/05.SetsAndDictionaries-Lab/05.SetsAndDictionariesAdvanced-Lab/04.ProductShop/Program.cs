using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> result = new Dictionary<string, Dictionary<string, double>>();

            string[] comand = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (comand[0] != "Revision")
            {
                string shop = comand[0];
                string product = comand[1];
                double price = double.Parse(comand[2]);

                if (!result.ContainsKey(shop))
                {
                    result.Add(shop, new Dictionary<string, double>());
                }

                if (!result[shop].ContainsKey(product))
                {
                    result[shop].Add(product, price);
                }

                comand = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            result = result.OrderBy(x => x.Key).ToDictionary(y => y.Key, z => z.Value);

            foreach (var shop in result)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
