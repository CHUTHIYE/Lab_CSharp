using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project24
{
    class Person
    {
        public string Name { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Person Name: " + Name);
        }
    }
}
