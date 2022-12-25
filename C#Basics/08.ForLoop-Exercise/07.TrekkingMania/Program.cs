using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGroups = int.Parse(Console.ReadLine());
            int totalKlimbers = 0;
            int everest = 0;
            int k2 = 0;
            int kilimanjaro = 0;
            int monthblan = 0;
            int musala = 0;

            //int[] peaks = new int[] {musala, k2, kilimanjaro, monthblan, musala};

            for (int i = 0; i < countOfGroups; i++)
            {
                int dudes = int.Parse(Console.ReadLine());
                totalKlimbers += dudes;

                if (dudes >= 41)
                {
                    everest += dudes;
                }
                else if (dudes >= 26)
                {
                    k2 += dudes;
                }
                else if (dudes >= 13)
                {
                    kilimanjaro += dudes;
                }
                else if (dudes >= 6)
                {
                    monthblan += dudes;
                }
                else
                {
                    musala += dudes;
                }
            }


            GetPercent(musala, totalKlimbers);
            GetPercent(monthblan, totalKlimbers);
            GetPercent(kilimanjaro, totalKlimbers);
            GetPercent(k2, totalKlimbers);
            GetPercent(everest, totalKlimbers);
            

            //Console.WriteLine($"{((musala/totalKlimbers)*100):f2}%");
            //Console.WriteLine($"{((monthblan/totalKlimbers)*100):f2}%");
            //Console.WriteLine($"{((kilimanjaro/totalKlimbers)*100):f2}%");
            //Console.WriteLine($"{((k2/totalKlimbers)*100):f2}%");
            //Console.WriteLine($"{((everest/totalKlimbers)*100):f2}%");


        }

        private static void GetPercent(int musala, int totalKlimbers)
        {
            Console.WriteLine($"{((double)musala / (double)totalKlimbers * 100):f2}%");
        }
    }
}
