using System;

public class Program
{
    public static void Main()
    {

        int primeSum = 0;
        int notPrimeSumm = 0;

        string input = Console.ReadLine();

        while (input != "stop")
        {
            int currentNum = int.Parse(input);

            if (currentNum < 0)
            {
                Console.WriteLine("Number is negative.");
                input = Console.ReadLine();
                continue;
            }

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(currentNum); i++)
            {
                if (currentNum % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primeSum += currentNum;
            }
            else
            {
                notPrimeSumm += currentNum;
            }


            input = Console.ReadLine();
        }

        Console.WriteLine("Sum of all prime numbers is: {0}", primeSum);
        Console.WriteLine("Sum of all non prime numbers is: {0}", notPrimeSumm);

    }
}