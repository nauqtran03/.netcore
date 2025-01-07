namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SanPham> list = new List<SanPham>();
            int option = 0;
            var kiemtra = true;
            do
            {
                Console.WriteLine("================================================");
                Console.WriteLine("1.Nhap san pham: ");
                Console.WriteLine("2.Xuat danh sach san pham: ");
                Console.WriteLine("3.Danh sach san pham co gia ban duoi 1tr VND: ");
                Console.WriteLine("4.Tim kiem san pham theo ten san pham. ");
                Console.WriteLine("================================================");
                Console.Write("Hay nhap lua chon cua ban: ");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n=========================");
                        Console.WriteLine("\t1.Nhap san pham dien tu: ");
                        Console.WriteLine("\t2.Nhap san pham thuc pham: ");
                        Console.WriteLine("\t3.Exit");
                        Console.Write("Nhap lua chon: ");
                        int loai = 0;
                        loai = int.Parse(Console.ReadLine());
                        switch (loai)
                        {
                            case 1:
                                Console.Write("Nhap ten san pham dien tu: ");
                                string tenDienTu = Console.ReadLine();
                                Console.Write("Nhap gia san pham dien tu: ");
                                double giaDienTu = double.Parse(Console.ReadLine());
                                Console.Write("Nhap thoi gian bao hanh: ");
                                int thoiGianBaoHanh = int.Parse(Console.ReadLine());
                                list.Add(new DienTu
                                {
                                    tenSanPham = tenDienTu,
                                    loaiSanPham = "Dien Tu",
                                    giaNhap = giaDienTu,
                                    thoiGianBaoHanh = thoiGianBaoHanh
                                });
                                break;
                            case 2:
                                Console.Write("Nhap ten san pham thuc pham: ");
                                string tenThucPham = Console.ReadLine();
                                Console.Write("Nhap gia san pham thuc pham: ");
                                double giaThucPham = double.Parse(Console.ReadLine());
                                Console.WriteLine("Nhap thoi gian bao hanh: ");
                                int ngayHetHan = int.Parse(Console.ReadLine());
                                list.Add(new ThucPham
                                {
                                    tenSanPham = tenThucPham,
                                    loaiSanPham = "Thuc Pham",
                                    giaNhap = giaThucPham,
                                    ngayHetHan = ngayHetHan
                                });
                                break;
                            case 3:
                                Console.WriteLine("Quay tro lai menu.");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        foreach (var t in list)
                        {
                            Console.Write(t.ToString());
                        }
                        break;
                    case 3:
                        var query = from m in list where m.getGia() < 1000000 select m;
                        foreach (var t in query)
                        { 
                            Console.Write(t.ToString());
                        }
                        break;
                    case 4:
                        string tenCanTim = Console.ReadLine();
                        var querySearch = from m in list where m.Equals(tenCanTim) select m;
                        foreach (var t in querySearch)
                        {
                            Console.Write(t.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Vui long chon so phu hop!!!");
                        break;
                }
            }while (kiemtra);
        }
    }
}
