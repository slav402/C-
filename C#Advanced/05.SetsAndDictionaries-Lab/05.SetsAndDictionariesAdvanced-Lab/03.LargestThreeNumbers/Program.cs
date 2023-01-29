using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers = numbers.OrderByDescending(n => n).Take(3).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
