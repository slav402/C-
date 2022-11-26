using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitNumber = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < digitNumber; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
