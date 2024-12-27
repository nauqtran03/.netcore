using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class DienTu : SanPham
    {
        public double giaNhap {  get; set; }
        public int thoiGianBaoHanh { get; set; }
        public override double getGia()
        {
            return giaNhap + (thoiGianBaoHanh * 10000);
        }
        public override string ToString()
        {
            return $"DienTu: {tenSanPham}, Loai: {loaiSanPham}, GiaNhap: {giaNhap}, BaoHanh: {thoiGianBaoHanh} tháng, Gia: {getGia():0,0} VNĐ";
        }
    }
}
