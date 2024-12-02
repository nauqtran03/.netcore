using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bttl_3_3
{
    
    internal class Studentmodel
        
    {
        List<Student> liststudent;
        public Studentmodel()
        {
            this.liststudent = new List<Student>()
            {
                new Student() {Id=1, Name="Quan",Age=18 },
                new Student(){Id =2, Name="Huy",Age=19},
                new Student(){Id=5,Name ="Ngan", Age=20},
                new Student(){Id=322,Name ="Ngan", Age=7},
                new Student(){Id=24,Name ="Ngan", Age=8},
            };
        }
        #region Methods
        public List<Student> getstudent() 
        {
            return this.liststudent;
        }
        public Student GetStudent(int id)
        {
            Student st = null;
            foreach (Student student in this.liststudent) {
                if(student.Id == id)
                {
                    st = student;
                }
            }
            return st;
        }
        public List<Student> GetStudent(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in this.liststudent)
            {
                if(student.Age >=x  && student.Age <= y)
                {
                    result.Add(student);    
                }
                
            }
            return result; 
        }
        #endregion
    }
}
