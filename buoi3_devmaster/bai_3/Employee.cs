using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Employee
    {
        private int id;
        private string name;
        private int age;

        public int Id { 
            get { return id; } 
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void Display()
        {
            Console.WriteLine("Mã: " +id);
            Console.WriteLine("Tên: " +name);
            Console.WriteLine("Tuổi: " +age);
        }
    }
}
