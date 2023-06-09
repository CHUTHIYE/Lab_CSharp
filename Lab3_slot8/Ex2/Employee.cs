using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public double CalculateBonus(double percentage)
        {
            return salary * percentage;
        }

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}\nAddress: {address}\nSIN: {sin}\nSalary: {salary:C}";
        }
    }
}
