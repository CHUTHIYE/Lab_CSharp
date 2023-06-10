using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project24
{
    class Staff : Employee
    {
        public string Title { get; set; }

        public override double CalculateTotalIncome()
        {
            return base.CalculateTotalIncome();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Staff Name: " + Name);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Bonus: " + Bonus);
        }
    }
}
