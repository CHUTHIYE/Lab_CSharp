using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project21
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "a";
            String b = "b";
            Swap<String>(ref a, ref b);
            System.Console.WriteLine(a + " " + b);
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;

        }
    }
}
