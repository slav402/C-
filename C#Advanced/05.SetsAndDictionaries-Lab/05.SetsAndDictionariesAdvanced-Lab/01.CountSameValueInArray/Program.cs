using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> result = new Dictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result.Add(input[i], 0);
                }

                result[input[i]]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
