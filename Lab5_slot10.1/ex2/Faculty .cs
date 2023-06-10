using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project24
{
    class Faculty : Employee
    {
        public string Rank { get; set; }

        public override double CalculateTotalIncome()
        {
            return base.CalculateTotalIncome() + 5000;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Faculty Name: " + Name);
            Console.WriteLine("Rank: " + Rank);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Bonus: " + Bonus);
        }
    }
}
