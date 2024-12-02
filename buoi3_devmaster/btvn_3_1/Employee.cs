using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn_3_1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicLevel {  get; set; }

        public double GetIncome()
        {
            return salaryLevel*basicLevel;
        }
        public void Display()
        {
            Console.WriteLine("Employee information: ");
            Console.WriteLine("ID: "+Id);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Year Of Birth: "+yearOfBirth);
            Console.WriteLine("Salary Level: "+ salaryLevel);
            Console.WriteLine("Basic Level: "+ basicLevel);
            Console.WriteLine("Income: " + GetIncome());

        }
    }
}
