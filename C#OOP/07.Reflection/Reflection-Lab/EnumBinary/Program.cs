Days promotions = Days.Tuesday | Days.Saturday | Days.Thursday;

if (promotions.HasFlag(Days.Monday))
{
    Console.WriteLine("Monday promotion");
}
if (promotions.HasFlag(Days.Tuesday))
{
    Console.WriteLine("Tuesday promotion");
}
if (promotions.HasFlag(Days.Wednesday))
{
    Console.WriteLine("Wednesday promotion");
}
if (promotions.HasFlag(Days.Thursday))
{
    Console.WriteLine("Thursday promotion");
}
if (promotions.HasFlag(Days.Friday))
{
    Console.WriteLine("Friday promotion");
}
if (promotions.HasFlag(Days.Saturday))
{
    Console.WriteLine("Saturday promotion");
}
if (promotions.HasFlag(Days.Sunday))
{
    Console.WriteLine("Sunday promotion");
}

Console.WriteLine((int)promotions);
Console.WriteLine(2 | 32 | 8);

enum Days
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 4,
    Thursday = 8,
    Friday = 16,
    Saturday = 32,
    Sunday = 64
}