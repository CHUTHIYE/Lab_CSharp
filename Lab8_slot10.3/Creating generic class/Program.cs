using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<String> pair = new Pair<string>("An", "Nga");
            Console.WriteLine("({0}, {1})", pair.First, pair.Second);
            Console.ReadLine();
        }
    }
}
