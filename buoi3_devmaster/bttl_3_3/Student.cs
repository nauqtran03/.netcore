﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bttl_3_3
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Display()
        {
            Console.WriteLine("Show student list");
            Console.WriteLine("Id: "+ Id);
            Console.WriteLine("Name: " +Name);
            Console.WriteLine("Age: "+Age);
        }
    }
}
