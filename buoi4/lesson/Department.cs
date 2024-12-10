using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Department : Employeee
    {
        int idDepartment = 1;
        string nameDepartment = "CNTT";

        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Id Department: {idDepartment}");
            Console.WriteLine($"Name Department: {nameDepartment}");
        }
    }
}
