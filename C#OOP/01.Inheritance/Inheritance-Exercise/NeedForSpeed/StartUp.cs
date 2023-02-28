using System;
namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double fuel = double.Parse(Console.ReadLine());
            int hPower = int.Parse(Console.ReadLine());
            
            Motorcycle honda = new Motorcycle(hPower, fuel);
            honda.Drive(3);

            RaceMotorcycle yamaha = new RaceMotorcycle(hPower, fuel);
            yamaha.Drive(3);

            SportCar bmv = new SportCar(hPower, fuel);
            bmv.Drive(3);

            Console.WriteLine(honda.Fuel);
            Console.WriteLine(yamaha.Fuel);
            Console.WriteLine(bmv.Fuel);
        }
    }
}
