using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            string input = Console.ReadLine();

            while (input != "NoMoreMoney")
            {
                double cash = double.Parse(input);

                if (cash < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                money += cash;

                Console.WriteLine($"Increase: {cash:f2}");

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {money:f2}");
        }
    }
}
