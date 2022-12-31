using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int countOfPieces = lenght * width;
            
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                countOfPieces -= int.Parse(input);

                if (countOfPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(countOfPieces)} pieces more.");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{countOfPieces} pieces are left.");
        }
    }
}
