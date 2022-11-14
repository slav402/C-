using System;
using System.Collections.Generic;

namespace _04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            List<double> priceList = new List<double> 
            { 
                2.60, 
                3.0, 
                4.10, 
                8.20, 
                2.0 
            };

            int countOfToys = 0;
            double money = 0;

            for (int i = 0; i <= 4; i++)
            {
                int count = int.Parse(Console.ReadLine());
                double price = count * priceList[i];

                money += price;
                countOfToys += count;
            }

            if (countOfToys >= 50)
            {
                money *= 0.75;
            }

            money *= 0.9;

            if (money >= holidayPrice)
            {
                Console.WriteLine($"Yes! {(money - holidayPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(holidayPrice - money):F2} lv needed.");
            }
        }
    }
}
