using System;

namespace _08.OnTimeForTheExam
{
	class Program
	{
		static void Main(string[] args)
		{
			int examHour = int.Parse(Console.ReadLine());
			int examMinutes = int.Parse(Console.ReadLine());
			int entryHour = int.Parse(Console.ReadLine());
			int entryMinutes = int.Parse(Console.ReadLine());

			if (entryHour == examHour)
			{
				if (entryMinutes <= examMinutes)
				{

					if ((examMinutes - entryMinutes) <= 30)
					{
						Console.WriteLine("on time");
						Console.WriteLine("{0} minutes before the start", examMinutes - entryMinutes);
					}
					else if ((examMinutes - entryMinutes) > 30)
					{
						Console.WriteLine("early");
						Console.WriteLine("{0} minutes before the start", examMinutes - entryMinutes);
					}
				}
				else
				{
					Console.WriteLine("Late");
					Console.WriteLine("{0} minutes after the start", entryMinutes - examMinutes);
				}

			}
			else if (entryHour < examHour)
			{
				int delay = ((examHour * 60) + examMinutes) - ((entryHour * 60) + entryMinutes);

				int hours = delay / 60;
				int minutes = delay % 60;

				if (delay <= 30)
				{
					Console.WriteLine("on time");
					Console.WriteLine("{0} minutes before the start", (examMinutes - entryMinutes + 60));
				}
				else if (delay < 60)
				{
					Console.WriteLine("Early");
					Console.WriteLine("{0} minutes before the start", delay);
				}
				else
				{
					Console.WriteLine("Early");
					Console.WriteLine("{0}:{1:D2} hours before the start", hours, minutes);
				}
			}
			else
			{
				int delay = ((entryHour * 60) + entryMinutes) - ((examHour * 60) + examMinutes);

				int hours = delay / 60;
				int minutes = delay % 60;

				if (delay < 60)
				{
					Console.WriteLine("Late");
					Console.WriteLine("{0} minutes after the start", delay);
				}
				else
				{
					Console.WriteLine("Late");
					Console.WriteLine("{0}:{1:D2} hours after the start", hours, minutes);
				}
			}
		}
	}
}
