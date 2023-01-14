using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (cars.Count != 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
