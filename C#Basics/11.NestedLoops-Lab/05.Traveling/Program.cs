using System;

namespace _07.Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double priceOfDestination = double.Parse(Console.ReadLine());

                while (priceOfDestination > 0)
                {
                    priceOfDestination -= double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
