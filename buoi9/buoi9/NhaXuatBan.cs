using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi9
{
    internal class NhaXuatBan
    {
        public int Id {  get; set; }
        public string TenNhaXuatBan { get; set; }
        public NhaXuatBan() { } 
        public NhaXuatBan(int Id, string TenNhaXuatBan) 
        {
            this.Id = Id;
            this.TenNhaXuatBan = TenNhaXuatBan;
        }
        public void Nhap_NXB()
        {
            Console.Write("Nhap id nha xuat ban: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten nha xuat ban: ");
            TenNhaXuatBan = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Id Nha Xuat Ban: {Id}, Ten Nha Xuat Ban: {TenNhaXuatBan}";
        }
    }
}
