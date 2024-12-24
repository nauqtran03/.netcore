using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8_2
{
    internal class Order
    {
        public int Id { get; set; }
        public string Product { get; set; }

        public Order(int Id, string Product) 
        {
            this.Id = Id;
            this.Product = Product;
        }
    }
}
