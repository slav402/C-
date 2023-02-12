using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Peugeot";
            car.Model = "307";
            car.Year = 2005;

            Console.WriteLine($"Make: {car.Model}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
