using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("SIN Validator");
            Console.WriteLine("==============");

            while (true)
            {
                Console.Write("SIN (0 to quit): ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine("Have a Nice Day!");
                    break;
                }

                if (ValidateSIN(input))
                {
                    Console.WriteLine("This is a valid SIN.");
                }
                else
                {
                    Console.WriteLine("This is not a valid SIN.");
                }
            }
        }

        public static bool ValidateSIN(string sin)
        {
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = sin.Length - 2; i >= 0; i -= 2)
            {
                int digit = int.Parse(sin[i].ToString());
                digit *= 2;

                while (digit > 0)
                {
                    sumEven += digit % 10;
                    digit /= 10;
                }
            }

            for (int i = sin.Length - 3; i >= 0; i -= 2)
            {
                int digit = int.Parse(sin[i].ToString());
                sumOdd += digit;
            }

            int total = sumEven + sumOdd;
            int nextHighest = (total / 10 + 1) * 10;
            int difference = nextHighest - total;
            int checkDigit = int.Parse(sin[sin.Length - 1].ToString());

            return difference == checkDigit;
        }

    }

}

