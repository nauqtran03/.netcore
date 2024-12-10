using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Animal
    {
        protected string food;
        protected string activity;
        public void Eat()
        {
            Console.WriteLine("Động vật ăn gì đó");
        }
        public void DoSomething()
        {
            Console.WriteLine("Động vật làm gì đó");
        }
    }
}
