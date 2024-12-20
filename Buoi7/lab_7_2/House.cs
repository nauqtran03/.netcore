using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class House
    {
        public string HouseNo {  get; set; }
        public int Price { get; set; }
    }
}
namespace Dealership
{
    public class Car
    {
        public string CarNo { get; set; }
        public int Price { get; set; }
    }
}