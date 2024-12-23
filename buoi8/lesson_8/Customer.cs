using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public Customer(int Id, string Name, string City, int Age) 
        {
            this.Id = Id;
            this.Name = Name;
            this.City = City;
            this.Age = Age;
        }
        public override string ToString()
        {
            return Id+"|"+Name+"|"+City+"|"+Age;
        }
    }
    internal class Province
    {
        public string City { get; set; }
        public int Capacity { get; set; }

        public Province(string City, int Capacity) 
        {
            this.Capacity = Capacity;
            this.City = City;
        }
        public override string ToString() {
            return City+"|"+Capacity;
        }
    }
}
