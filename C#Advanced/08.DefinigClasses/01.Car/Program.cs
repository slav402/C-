using System;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Model}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
