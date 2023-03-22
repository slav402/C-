using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            double calories = 0;
            double toppinpCalories = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (tokens[0].ToLower() == "dough")
                    {
                        Dough testo = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
                        calories += testo.GetDoughCalories();
                    }
                    else
                    {
                        Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                        calories += topping.GetToppingCalories();
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                Console.WriteLine($"{calories:f2}");
            }
        }
    }
}
