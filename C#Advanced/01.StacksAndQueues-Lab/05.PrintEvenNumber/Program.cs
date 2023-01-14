using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> evenNums = new Queue<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenNums.Enqueue(input[i]);
                }
            }

            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
