using System;

namespace E04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number <= 399)
                {
                    p2++;
                }
                else if (number <= 599)
                {
                    p3++;
                }
                else if (number <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            Console.WriteLine("{0:F2}%", (p1 / n * 100));
            Console.WriteLine("{0:F2}%", (p2 / n * 100));
            Console.WriteLine("{0:F2}%", (p3 / n * 100));
            Console.WriteLine("{0:F2}%", (p4 / n * 100));
            Console.WriteLine("{0:F2}%", (p5 / n * 100));
        }
    }
}
