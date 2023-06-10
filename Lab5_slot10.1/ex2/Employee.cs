using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project24
{
    class Employee : Person
    {
        public double Salary { get; set; }
        public double Bonus { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Bonus: " + Bonus);
        }

        public virtual double CalculateTotalIncome()
        {
            return Salary + Bonus;
        }

        public void ValidateAmount()
        {
            if (this is Faculty && Salary < 60000)
            {
                throw new AmountException(Name, "Salary for Senior Lecturer should be at least 60,000.");
            }

            if (Bonus > 10000)
            {
                throw new AmountException(Name, "Bonus should not exceed 10,000.");
            }
        }
    }
}
