using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bttl_3_1
{
    internal class Car
    {
        public string make;
        public string model;
        public string color;
        public int year;

        public void Start()
        {
            Console.WriteLine(model+" Khoi Dong");
        }
        public void Stop()
        {
            Console.WriteLine(model + " Dung");
        }
    }
}
