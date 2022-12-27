using System;

namespace _04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());
            int num = 1;

            while (num <= targetNum)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
