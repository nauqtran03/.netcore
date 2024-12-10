using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    sealed internal class Product
    {
        protected string id;
        protected string name;
        protected string description;
        protected double price;
        public Product(string id, string name, string description, double price)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
    //// biên dịch không đọc được do từ khóa sealed
    //internal class Product2 : Product
    //{

    //}
}
