using System;

namespace _03.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crokodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile"); 
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
