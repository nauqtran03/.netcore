using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public Student() { }

        public Student(int Id, string Name, string FirstName)
        {
            this.Id = Id;
            this.Name = Name;
            this.FirstName = FirstName;
        }
        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public Student(string Name, string FirstName)
        {
            this.Name = Name;
            this.FirstName = FirstName;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"FirstName: {FirstName}");
        }
    }
}
