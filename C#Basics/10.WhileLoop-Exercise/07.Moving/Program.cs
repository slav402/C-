using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int heigh = int.Parse(Console.ReadLine());

            int freeRoom = width * lenght * heigh;

            while (freeRoom > 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{freeRoom} Cubic meters left.");
                    return;
                }

                freeRoom -= int.Parse(input);
            }

            Console.WriteLine($"No more free space! You need {Math.Abs(freeRoom)} Cubic meters more.");
        }
    }
}
