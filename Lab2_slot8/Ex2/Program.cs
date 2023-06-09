using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Chu", "Yen", "Hanoi, Vietnam", 0123456789, 50000);

            double bonus = employee.CalculateBonus(0.1);
            Console.WriteLine($"Bonus: {bonus:C}");

            Console.WriteLine(employee.ToString());

            Console.ReadLine();
        }
    }
}
