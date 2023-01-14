using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int count = int.Parse(Console.ReadLine());

            Queue<string> plaingChildren = new Queue<string>(input);

            while (plaingChildren.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    plaingChildren.Enqueue(plaingChildren.Dequeue());
                }

                Console.WriteLine($"Removed {plaingChildren.Dequeue()}");
            }

            Console.WriteLine($"Last is {plaingChildren.Dequeue()}");
        }
    }
}
