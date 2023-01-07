using System;

public class Program
{
	public static void Main()
	{

		int primeSum = 0;
		int notPrimeSumm = 0;

		while (true)
		{
			string input = Console.ReadLine();

			if (input == "stop")
			{
				break;
			}

			int entringNum = int.Parse(input);

			if (entringNum < 0)
			{
				Console.WriteLine("Number is negative.");

			}
			else
			{
				bool isPrime = true;

				for (int i = 2; i <= (int)Math.Sqrt(entringNum); i++)
				{
					if (entringNum % i == 0)
					{
						isPrime = false;
						break;
					}
				}
				if (isPrime)
				{
					primeSum += entringNum;
				}
				else
				{
					notPrimeSumm += entringNum;
				}
			}
		}

		Console.WriteLine("Sum of all prime numbers is: {0}", primeSum);
		Console.WriteLine("Sum of all non prime numbers is: {0}", notPrimeSumm);

	}
}