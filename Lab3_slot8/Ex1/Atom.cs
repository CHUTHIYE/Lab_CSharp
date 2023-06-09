using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Atom
    {
        private int atomicNumber;
        private string symbol;
        private string fullName;
        private double atomicWeight;

        public bool Accept()
        {
            Console.Write("Enter atomic number: ");
            if (!int.TryParse(Console.ReadLine(), out atomicNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid atomic number.");
                return false;
            }

            Console.Write("Enter symbol: ");
            symbol = Console.ReadLine();

            Console.Write("Enter full name: ");
            fullName = Console.ReadLine();

            Console.Write("Enter atomic weight: ");
            if (!double.TryParse(Console.ReadLine(), out atomicWeight))
            {
                Console.WriteLine("Invalid input. Please enter a valid atomic weight.");
                return false;
            }

            return true;
        }

        public void Display()
        {
            Console.WriteLine($"{atomicNumber} {symbol} {fullName} {atomicWeight}");
        }
    }
}
