using System;

public class Program
{
	public static void Main()
	{
		double money = double.Parse(Console.ReadLine());
		string season = Console.ReadLine();

		if (money <= 100)
		{
			Console.WriteLine("Somewhere in Bulgaria");

			if (season == "summer")
			{
				Console.WriteLine("Camp - {0:F2}", money * 0.30);
			}
			else
			{
				Console.WriteLine("Hotel - {0:F2}", money * 0.70);
			}
		}
		else if (money <= 1000)
		{
			Console.WriteLine("Somewhere in Balkans");

			if (season == "summer")
			{
				Console.WriteLine("Camp - {0:F2}", money * 0.40);
			}
			else
			{
				Console.WriteLine("Hotel - {0:F2}", money * 0.80);
			}
		}
		else
		{
			Console.WriteLine("Somewhere in Europe");
			Console.WriteLine("Hotel - {0:F2}", money * 0.90);
		}
	}
}