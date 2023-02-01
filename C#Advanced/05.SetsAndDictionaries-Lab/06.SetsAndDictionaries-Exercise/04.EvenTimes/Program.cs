using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int curentNum = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(curentNum))
                {
                    numbers.Add(curentNum, 0);
                }

                numbers[curentNum]++;
            }

            Console.WriteLine(numbers.Single(x => x.Value % 2 == 0).Key);
        }
    }
}
