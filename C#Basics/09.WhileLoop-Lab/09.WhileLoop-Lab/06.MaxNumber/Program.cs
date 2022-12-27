using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNum = int.MinValue;

            while (input != "Stop")
            {
                int parce = int.Parse(input);

                if (parce > maxNum)
                {
                    maxNum = parce;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNum);
        }
    }
}
