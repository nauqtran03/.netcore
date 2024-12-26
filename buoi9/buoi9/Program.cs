using System.Security.Cryptography.X509Certificates;

namespace buoi9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Xây dựng 1 chương trình quản lí nhân viên
            //1. Xây dung class Sach, Nha Xuat Ban, Tac Gia.
            //1.1 Class Sach: ID, TenSach, Id_TacGia, Id_NhaXuatBan, NamXuatBan, SoTrang;
            //    Class NhaXuatBan: Id, Ten_Nha_Xuat_Ban
            //    Class TacGia: Id, Ten_Tac_Gia
            //1.2 Xây dựng các contructor, phương thức nhập xuất dữ liệu;
            //2. Xây dựng chức năng nhập xuất xóa thông tin Tác giá, Nhà Xuất Bản, Sách
            //3. Hiển thị dữ liệu ra ngoài màn hình 
            //3.1 Hiển thị tất cả sách
            //3.2 Hiển thị theo group tác giả
            //3.3 Tìm kiếm theo tên sách;
            //3.4 Tìm kiếm theo id tác giả


            List<Sach> dsSach = new List<Sach>()
            {
                new Sach(1, "Mat Biec", 1, 1, 1990, 300),
                new Sach(2, "Trang Sách Mới", 2, 2, 1995, 350),
                new Sach(3, "Tinh Yeu Quan Trong", 3, 3, 2000, 400),
                new Sach(4, "Dai Hoc Duong", 4, 4, 2010, 450),
                new Sach(5, "Cuoc Song Hoa", 5, 5, 2015, 500)
            };
            List<NhaXuatBan> dsNhaXuatBan = new List<NhaXuatBan>()
            {
                new NhaXuatBan(1, "Kim Dong"),
                new NhaXuatBan(2, "Tre"),
                new NhaXuatBan(3, "Dai Loc"),
                new NhaXuatBan(4, "Nha Nam"),
                new NhaXuatBan(5, "Phan Thi")
            };
            List<TacGia> dsTacGia = new List<TacGia>()
            {
                new TacGia(1, "Nguyen Nhat Anh"),
                new TacGia(2, "To Hoai"),
                new TacGia(3, "Ho Anh Thai"),
                new TacGia(4, "Nguyen Du"),
                new TacGia(5, "Pham Quynh")
            };

            
            
        }
    }
}
