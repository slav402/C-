using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNum = int.MaxValue;

            while (input != "Stop")
            {
                int parce = int.Parse(input);

                if (parce < minNum)
                {
                    minNum = parce;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNum);
        }
    }
}
