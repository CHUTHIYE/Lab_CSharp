using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> temperatures = new List<double> { 20.5, 25.8, 23.1, 27.6, 22.9, 26.4, 24.7 };

            int count = CountTemperaturesAbove(temperatures, 25);
            Console.WriteLine($"Number of temperatures equal to or exceeding 25 degrees: {count}");

            int greaterCount = GreaterCount(temperatures, 25.5);
            Console.WriteLine($"Number of temperatures greater than or equal to 25.5 degrees: {greaterCount}");
        }

        public static int CountTemperaturesAbove(List<double> temperatures, double minTemperature)
        {
            int count = 0;
            foreach (double temperature in temperatures)
            {
                if (temperature >= minTemperature)
                {
                    count++;
                }
            }
            return count;
        }

        public static int GreaterCount(List<double> list, double min)
        {
            int count = 0;
            foreach (double value in list)
            {
                if (value >= min)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
