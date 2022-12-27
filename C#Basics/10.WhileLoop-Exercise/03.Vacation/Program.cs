using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double targetMoney = double.Parse(Console.ReadLine());
            double startMoney = double.Parse(Console.ReadLine());
            int spendInRow = 0;
            int days = 0;


            while (spendInRow < 5)
            {
                string input = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                if (input == "spend")
                {
                    spendInRow++;
                    days++;
                    startMoney -= currentMoney;

                    if (startMoney < 0)
                    {
                        startMoney = 0;
                    }
                }
                else
                {
                    spendInRow = 0;
                    days++;

                    startMoney += currentMoney;

                    if (startMoney >= targetMoney)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        return;
                    }
                }
            }

            Console.WriteLine("You can't save the money.");
            Console.WriteLine(days);
        }
    }
}
