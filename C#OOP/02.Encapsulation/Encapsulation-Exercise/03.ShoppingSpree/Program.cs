using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string[] personInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                persons = PersonReader(personInput);
                products = ProductReader(productInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            while (true)
            {
                string enter = Console.ReadLine();

                if (enter == "END")
                {
                    break;
                }

                string[] parts = enter.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = parts[0];
                string productName = parts[1];

                Person person = new Person();
                Product product = new Product();

                foreach (var item in persons)
                {
                    if (item.Name == personName)
                    {
                        person = item;
                    }
                }

                foreach (var item in products)
                {
                    if (item.Name == productName)
                    {
                        product = item;
                    }
                }

                try
                {
                    person.AddProdduct(product);

                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }

        private static List<Product> ProductReader(string[] productInput)
        {
            List<Product> resultProductList = new List<Product>();

            foreach (var pair in productInput)
            {
                string[] productNameMoneyPair = pair.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string currentProductName = productNameMoneyPair[0];
                decimal currentMoney = decimal.Parse(productNameMoneyPair[1]);

                Product product = new Product(currentProductName, currentMoney);
                resultProductList.Add(product);
            }

            return resultProductList;
        }

        private static List<Person> PersonReader(string[] personInput)
        {
            List <Person> resulPersonList = new List<Person>();

            foreach (var pair in personInput)
            {
                string[] personMoneyPair = pair.Split("=", StringSplitOptions.RemoveEmptyEntries);
                
                string currentPersonName = personMoneyPair[0];
                decimal currentMoney = decimal.Parse(personMoneyPair[1]);

                Person person = new Person(currentPersonName, currentMoney);
                resulPersonList.Add(person);
            }
            
            return resulPersonList;
        }
    }
}
