using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentInt = int.Parse(Console.ReadLine());
                sum += currentInt;

                if (currentInt > maxValue)
                {
                    maxValue = currentInt;
                }
            }

            int sumWitoutMaxNum = sum - maxValue;

            if (sumWitoutMaxNum == maxValue)
            {
                Console.WriteLine($"Yes\nSum = {maxValue}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(sumWitoutMaxNum - maxValue)}");
            }
        }
    }
}
