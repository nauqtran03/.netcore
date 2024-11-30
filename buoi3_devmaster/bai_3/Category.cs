using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Category
    {
        private int id;
        private string name;

        public int ID {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Display()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
        }
    }
}
