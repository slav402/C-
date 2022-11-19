using System;
using System.Linq;

namespace _09.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] fruit = new string[] { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };

            int someNum = Array.IndexOf(fruit, input);

            if (someNum > -1)
            {
                Console.WriteLine("fruit");
            }
            else
            {
                Console.WriteLine("vegetable");
            }
        }
    }
}
