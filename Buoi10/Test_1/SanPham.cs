using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    abstract class SanPham
    {
        public string tenSanPham {  get; set; }
        public string loaiSanPham { get; set; }

        public abstract double getGia();
    }
}
