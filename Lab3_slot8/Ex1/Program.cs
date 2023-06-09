using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Atom[] atoms = new Atom[10];

            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");

            for (int i = 0; i < atoms.Length; i++)
            {
                atoms[i] = new Atom();

                Console.WriteLine($"Enter atomic element {i + 1}:");

                while (!atoms[i].Accept())
                {
                    // Retry input if invalid
                }
            }

            Console.WriteLine("No\tSym\tName\tWeight");
            Console.WriteLine("------------------------------------");

            foreach (Atom atom in atoms)
            {
                atom.Display();
            }
        }
    }
}
