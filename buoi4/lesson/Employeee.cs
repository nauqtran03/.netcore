using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Employeee
    {
        int id = 10;
        string name = "Quan";
        int age = 18;

        public void Display()
        {
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
