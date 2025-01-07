using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class ThucPham : SanPham
    {
        public double giaNhap {  get; set; }
        public int ngayHetHan {get; set; }
        public override double getGia()
        {
            return giaNhap - ((30 - ngayHetHan) * 5000);
        }
        public override string ToString()
        {
            return $"\nTen Thuc Pham: {tenSanPham}, Loai: {loaiSanPham}, GiaNhap: {giaNhap}, NgayHetHan: {ngayHetHan} ngay, Gia: {getGia():0,0} VNĐ\n";
        }
    }
}
