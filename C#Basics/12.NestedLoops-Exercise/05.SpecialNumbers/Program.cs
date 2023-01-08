using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;
                int number = i;

                while (number > 0)
                {
                    int lastDigit = number % 10;

                    if (lastDigit == 0 || input % lastDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    number /= 10;
                }

                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }

            //for (int x1 = 1; x1 < 10; x1++)
            //{
            //    for (int x2 = 1; x2 < 10; x2++)
            //    {
            //        for (int x3 = 1; x3 < 10; x3++)
            //        {
            //            for (int x4 = 1; x4 < 10; x4++)
            //            {
            //                if (input % x1 == 0 &&
            //                    input % x2 == 0 &&
            //                    input % x3 == 0 &&
            //                    input % x4 == 0)
            //                {
            //                    Console.Write($"{x1}{x2}{x3}{x4} ");
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}
