using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi9
{
    internal class Sach
    {
        public int Id {  get; set; }
        public string TenSach { get; set; }
        public int Id_TacGia {  get; set; }
        public int Id_NhaXuatBan {  get; set; }
        public int NamXuatBan { get; set; }
        public int SoTrang {  get; set; }

        public Sach() { }
        public Sach(int Id, string TenSach, int Id_TacGia, int Id_NhaXuatBan, int NamXuatBan, int SoTrang) 
        {
            this.Id = Id;
            this.TenSach = TenSach;
            this.Id_TacGia = Id_TacGia;
            this.Id_NhaXuatBan = NamXuatBan;
            this.NamXuatBan = NamXuatBan;
            this.SoTrang = SoTrang;
        }
        public static Sach Nhap_Sach()
        {
            Console.Write("Nhap id sach: ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten sach: ");
            string TenSach = Console.ReadLine();
            Console.Write("Nhap id tac gia: ");
            int Id_TacGia = int.Parse(Console.ReadLine());
            Console.Write("Nhap id nha xuat ban: ");
            int Id_NhaXuatBan = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam xuat ban: ");
            int NamXuatBan = int.Parse(Console.ReadLine());
            Console.Write("Nhap so trang: ");
            int SoTrang = int.Parse(Console.ReadLine());

            return new Sach(Id,TenSach,Id_TacGia,Id_NhaXuatBan,NamXuatBan,SoTrang);
        }
        public override string ToString()
        {
            return $"Id sach: {Id}, Ten Sach: {TenSach}, Id Tac Gia: {Id_TacGia}, Id Nha Xuat Ban: {Id_NhaXuatBan}, Nam Xuat Ban: {NamXuatBan}, So Trang: {SoTrang}";
        }
    }
}
