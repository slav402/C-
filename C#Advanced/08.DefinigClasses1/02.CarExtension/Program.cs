using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Peugeot";
            car.Model = "307";
            car.Year = 2005;
            car.FuelQuantity = 200;
            car.FuelConsumption = 2;
            car.Drive(10);
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
