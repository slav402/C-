using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> clientNames = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    int count = clientNames.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(clientNames.Dequeue());
                    }
                }
                else
                {
                    clientNames.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{clientNames.Count} people remaining.");
        }
    }
}
