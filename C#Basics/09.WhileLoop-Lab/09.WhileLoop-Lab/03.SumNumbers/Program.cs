using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());
            int inputNum = int.Parse(Console.ReadLine());

            while (inputNum < targetNum)
            {
                inputNum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(inputNum);
        }
    }
}
