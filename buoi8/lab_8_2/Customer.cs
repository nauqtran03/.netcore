using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8_2
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int Id, string Name) 
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
