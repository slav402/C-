using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            double priceOfWashingMashine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toyCount = 0;
            double money = 0;
            int counter = 0;

            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    money += (10 * counter - 1);
                }
                else
                {
                    //toyCount++;
                    money += toyPrice;
                }
            }

            if (money < priceOfWashingMashine)
            {
                Console.WriteLine($"No! {(priceOfWashingMashine - money):f2}");
            }
            else
            {
                Console.WriteLine($"Yes! {(money - priceOfWashingMashine):f2}");
            }
        }
    }
}
