using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double changeToCoins = Math.Floor(change * 100);
            int counter = 0;

            while (changeToCoins != 0)
            {
                if (changeToCoins >= 200)
                {
                    changeToCoins -= 200;
                    counter++;
                }
                else if (changeToCoins >= 100)
                {
                    changeToCoins -= 100;
                    counter++;
                }
                else if (changeToCoins >= 50)
                {
                    changeToCoins -= 50;
                    counter++;
                }
                else if (changeToCoins >= 20)
                {
                    changeToCoins -= 20;
                    counter++;
                }
                else if (changeToCoins >= 10)
                {
                    changeToCoins -= 10;
                    counter++;
                }
                else if (changeToCoins >= 5)
                {
                    changeToCoins -= 5;
                    counter++;
                }
                else if (changeToCoins >= 2)
                {
                    changeToCoins -= 2;
                    counter++;
                }
                else if (changeToCoins >= 1)
                {
                    changeToCoins -= 1;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
