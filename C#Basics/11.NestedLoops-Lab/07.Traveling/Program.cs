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
                int priceOfDestination = int.Parse(Console.ReadLine());

                while (priceOfDestination > 0)
                {
                    priceOfDestination -= int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
