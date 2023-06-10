using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project27
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 10.2, 15.5, 20.1, 25.3, 30.4, 35.7, 40.9 };

            int greaterCount = GreaterCount(numbers, 25.0);
            Console.WriteLine($"Number of elements greater than or equal to 25.0: {greaterCount}");
        }

        public static int GreaterCount(IEnumerable<double> enumerable, double min)
        {
            int count = 0;
            foreach (double value in enumerable)
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
