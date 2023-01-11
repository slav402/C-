using System;
using System.Numerics;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int countOfNUmbers = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= countOfNUmbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
