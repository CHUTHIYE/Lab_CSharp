using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project24
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person1 = new Person { Name = "John Doe" };
                Person person2 = new Employee { Name = "Chu Yen", Salary = 50000, Bonus = 12000 };
                Person person3 = new Faculty { Name = "Jane Smith", Salary = 65000, Bonus = 5000, Rank = "Senior Lecturer" };
                Person person4 = new Staff { Name = "Amy Brown", Salary = 55000, Bonus = 8000, Title = "Manager" };

                // Demonstrate polymorphism
                Person[] people = { person1, person2, person3, person4 };

                foreach (var person in people)
                {
                    person.DisplayInfo();
                    Console.WriteLine("Total Income: " + CalculateTotalIncome(person));
                    Console.WriteLine();
                }

                // Validate amounts
                ValidateAmount(person2);
                ValidateAmount(person3);
                ValidateAmount(person4);
            }
            catch (AmountException ex)
            {
                Console.WriteLine("Amount Exception for {0}: {1}", ex.PersonName, ex.Message);
            }
        }

        public static double CalculateTotalIncome(Person person)
        {
            if (person is Employee employee)
            {
                return employee.CalculateTotalIncome();
            }

            return 0;
        }

        public static void ValidateAmount(Person person)
        {
            if (person is Employee employee)
            {
                employee.ValidateAmount();
            }
        }
    }
}
