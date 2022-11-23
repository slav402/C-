using System;

public class Program
{
	public static void Main()
	{
		string month = Console.ReadLine();
		int days = int.Parse(Console.ReadLine());

		double nightInStudio = 0.0;
		double nightInApartment = 0.0;

		double priceStudio = 0.0;
		double priceApartment = 0.0;


		switch (month)
		{
			case "May":
			case "October":
				nightInStudio = 50.0;
				nightInApartment = 65.0;

				if (days <= 7)
				{
					priceStudio = nightInStudio * days;
					priceApartment = nightInApartment * days;
				}
				else if (days <= 14)
				{
					priceStudio = nightInStudio * days * 0.95;
					priceApartment = nightInApartment * days;
				}
				else
				{
					priceStudio = nightInStudio * days * 0.7;
					priceApartment = nightInApartment * days * 0.9;
				}
				break;

			case "June":
			case "September":
				nightInStudio = 75.20;
				nightInApartment = 68.70;

				if (days <= 14)
				{
					priceStudio = nightInStudio * days;
					priceApartment = nightInApartment * days;
				}
				else
				{
					priceStudio = nightInStudio * days * 0.8;
					priceApartment = nightInApartment * days * 0.9;
				}
				break;

			case "July":
			case "August":
				nightInStudio = 76.0;
				nightInApartment = 77.0;

				if (days <= 14)
				{
					priceStudio = nightInStudio * days;
					priceApartment = nightInApartment * days;
				}
				else
				{
					priceStudio = nightInStudio * days;
					priceApartment = nightInApartment * days * 0.9;
				}
				break;
		}

		Console.WriteLine("Apartment: {0:F2} lv.", priceApartment);
		Console.WriteLine("Studio: {0:F2} lv.", priceStudio);

	}
}