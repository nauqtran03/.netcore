using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_3
{
    internal class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public double Avg {  get; set; }

        public Student(string Id, string FirstName,string LastName,string Gender, double Avg) 
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Avg = Avg;
        }
        public override string ToString()
        {
            return $"\nId: {Id}, \nFirstName: {FirstName}, \nLastName: {LastName}, \nGender: {Gender}, \nAvg: {Avg} ";
        }

    }
}
