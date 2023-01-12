using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Stack<int> expresion = new Stack<int>(input);

            List<string> comand = Console.ReadLine().Split().ToList();

            while (comand[0].ToLower() != "end")
            {
                if (comand[0].ToLower() == "add")
                {
                    expresion.Push(int.Parse(comand[1]));
                    expresion.Push(int.Parse(comand[2]));
                }
                else
                {
                    int removeCount = int.Parse(comand[1]);

                    if (expresion.Count > removeCount)
                    {
                        for (int i = 0; i < removeCount; i++)
                        {
                            expresion.Pop();
                        }
                    }
                }

                comand = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine($"Sum: {expresion.Sum()}");
        }
    }
}
