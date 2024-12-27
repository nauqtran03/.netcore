namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SanPham> list = new List<SanPham>();
            do
            {
                Console.WriteLine("================================================");
                Console.WriteLine("1.Nhap san pham: ");
                Console.WriteLine("2.Xuat danh sach san pham: ");
                Console.WriteLine("3.Danh sach san pham co gia ban duoi 1tr VND: ");
                Console.WriteLine("4.Tim kiem san pham theo ten san pham. ");
                Console.WriteLine("================================================");
                Console.Write("Hay nhap lua chon cua ban: ");
                int option = 0;
                option= int.Parse(Console.ReadLine());
                int loai = 0;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("=========================");
                        Console.WriteLine("\t1.Nhap san pham dien tu: ");
                        Console.WriteLine("\t2.Nhap san pham thuc pham: ");
                        Console.WriteLine("\t3.Exit");
                        switch (loai)
                        {
                            case 1:
                                Console.Write("Nhap ten san pham dien tu: ");
                                string tenDienTu = Console.ReadLine();
                                Console.Write("Nhap gia san pham dien tu: ");
                                double giaDienTu = double.Parse(Console.ReadLine());
                                Console.WriteLine("Nhap thoi gian bao hanh: ");
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
                                Console.Write("Nhap ten san pham dien tu: ");
                                string tenThucPham = Console.ReadLine();
                                Console.Write("Nhap gia san pham dien tu: ");
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
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Vui long chon so phu hop!!!");
                        break;
                }
            }while (true);
        }
    }
}
