using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = 0; i < rooms; i++)
            {
                Console.Write($"L{levels}{i} ");
            }
            Console.WriteLine();

            if (levels > 1)
            {
                for (int i = levels-1; i > 0; i--)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"O{i}{j} ");
                        }
                        else
                        {
                            Console.Write($"A{i}{j} ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
