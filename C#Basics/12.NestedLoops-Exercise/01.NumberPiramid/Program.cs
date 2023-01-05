using System;

public class Program
{
	public static void Main()
	{
		int inputNumber = int.Parse(Console.ReadLine());
		int counter = 0;

		for (int i = 1; i <= inputNumber; i++)
		{
			for (int j = 0; j < i; j++)
			{
				counter++;

				if (counter <= inputNumber)
				{
					Console.Write(counter + " ");
				}
				else
				{
					break;
				}
			}
			Console.WriteLine();
		}
	}
}