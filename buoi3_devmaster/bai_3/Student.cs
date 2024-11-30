using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }

        public void Display()
        {
            Console.WriteLine("Id: "+Id);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Mark 1: "+Mark1);
            Console.WriteLine("Mart 2: "+Mark2);
            Console.WriteLine("Mark 3: "+Mark3);
        }
        public double Average()
        {
            double avg = (Mark1+Mark2+Mark3)/3;
            return avg;
        }
        public double Sum (double a, double b)
        {
            return a + b;
        }
        public int Sum (int a, int b)
        {
            return a + b;
        }
    }
}
