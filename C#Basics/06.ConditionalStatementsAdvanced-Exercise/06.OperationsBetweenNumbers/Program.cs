using System;

public class Program
{
	public static void Main()
	{
		double num1 = double.Parse(Console.ReadLine());
		double num2 = double.Parse(Console.ReadLine());
		string action = Console.ReadLine();

		string evenOdd;
		double operation = 0.0;

		switch (action)
		{
			case "+":
				operation = num1 + num2;
				if (operation % 2 == 0)
				{
					evenOdd = "even";
				}
				else
				{
					evenOdd = "odd";
				}
				Console.WriteLine("{0} + {1} = {2} - {3}", num1, num2, (num1 + num2), evenOdd);
				break;

			case "-":
				operation = num1 - num2;
				if (operation % 2 == 0)
				{
					evenOdd = "even";
				}
				else
				{
					evenOdd = "odd";
				}
				Console.WriteLine("{0} - {1} = {2} - {3}", num1, num2, (num1 - num2), evenOdd);
				break;

			case "*":
				operation = num1 * num2;
				if (operation % 2 == 0)
				{
					evenOdd = "even";
				}
				else
				{
					evenOdd = "odd";
				}
				Console.WriteLine("{0} * {1} = {2} - {3}", num1, num2, (num1 * num2), evenOdd);
				break;

			case "/":
				if (num2 == 0)
				{
					Console.WriteLine("Cannot divide {0} by zero", num1);

				}
				else
				{
					Console.WriteLine("{0} / {1} = {2:F2}", num1, num2, (num1 / num2));
				}
				break;

			case "%":
				if (num2 == 0)
				{
					Console.WriteLine("Cannot divide {0} by zero", num1);
				}
				else
				{
					Console.WriteLine("{0} % {1} = {2}", num1, num2, (num1 % num2));
				}
				break;
		}
	}
}