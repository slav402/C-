using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pizzaName = Console.ReadLine().Split()[1];
            string[] doughData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Dough testo = new Dough(doughData[1], doughData[2], int.Parse(doughData[3]));
                Pizza pizza = new Pizza(pizzaName, testo);

                string input;

                while ((input = Console.ReadLine()) != "END")
                {
                    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));

                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
