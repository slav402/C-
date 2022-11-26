using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());

                if (inputNum < minNum)
                {
                    minNum = inputNum;
                }

                if (inputNum > maxNum)
                {
                    maxNum = inputNum;
                }
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
