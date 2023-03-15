using System;

namespace BoxData
{
    public class StratUp
    {
        static void Main(string[] args)
        {
            try
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double heigth = double.Parse(Console.ReadLine());

                Box someBox = new Box(length, width, heigth);

                Console.WriteLine($"Surface Area - {someBox.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {someBox.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {someBox.CalculateVolume():f2}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
