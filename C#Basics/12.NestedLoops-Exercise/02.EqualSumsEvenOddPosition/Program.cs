using System;

public class Program
{
	public static void Main()
	{
		int firstNum = int.Parse(Console.ReadLine());
		int secondNum = int.Parse(Console.ReadLine());

		for (int i = firstNum; i <= secondNum; i++)
		{
			int evenSum = 0;
			int oddSum = 0;
			string numToString = i.ToString();

			for (int j = 0; j < numToString.Length; j++)
			{
				int currentPosition = int.Parse(numToString[j].ToString());

				if (j % 2 == 0)
				{
					evenSum += currentPosition;
				}
				else
				{
					oddSum += currentPosition;
				}
			}

			if (evenSum == oddSum)
			{
				Console.Write(i + " ");
			}
		}
	}
}