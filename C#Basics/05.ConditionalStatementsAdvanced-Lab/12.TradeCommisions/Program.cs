using System;

namespace _12.TradeCommisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commision = 0.0;

            if (sales < 0)
            {
                Console.WriteLine("error");
            }
            else if (sales <= 500)
            {
                switch (city)
                {
                    case "Sofia": commision = 0.05; break;
                    case "Varna": commision = 0.045; break;
                    case "Plovdiv": commision = 0.055; break;
                    
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia": commision = 0.07; break;
                    case "Varna": commision = 0.075; break;
                    case "Plovdiv": commision = 0.08; break;

                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia": commision = 0.08; break;
                    case "Varna": commision = 0.1; break;
                    case "Plovdiv": commision = 0.12; break;

                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                switch (city)
                {
                    case "Sofia": commision = 0.12; break;
                    case "Varna": commision = 0.13; break;
                    case "Plovdiv": commision = 0.145; break;

                    default: Console.WriteLine("error"); break; ;
                }
            }

            if (commision != 0)
            {
                Console.WriteLine($"{sales*commision:f2}");
            }
        }
    }
}
