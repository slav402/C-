using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int guys = int.Parse(Console.ReadLine());
            double oneCostumePrice = double.Parse(Console.ReadLine());

            double decors = money * 0.1;
            double allCostumePrice = oneCostumePrice * guys;

            if (guys > 150)
            {
                allCostumePrice *= 0.9;
            }

            double moviePrice = decors + allCostumePrice;

            if (money - moviePrice >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", money - moviePrice);
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", moviePrice - money);
            }
        }
    }
}
