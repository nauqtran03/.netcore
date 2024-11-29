using System;
using System.Text;

namespace LaiSuatTienGui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số tiền gửi (VNĐ): ");
            double tienGoc = double.Parse(Console.ReadLine());

            Console.Write("Nhập lãi suất ngân hàng (theo năm, %): ");
            double laiSuatNam = double.Parse(Console.ReadLine());

            Console.Write("Nhập số tháng gửi: ");
            int soThang = int.Parse(Console.ReadLine());

            double tienLaiThang;
            double tongTien = tienGoc;

            Console.WriteLine("\nTháng\tTiền gốc + lãi\tTiền lãi tháng");

            for (int thang = 1; thang <= soThang; thang++)
            {
                double laiSuatThang = (laiSuatNam / 12) / 100;
          
                tienLaiThang = tongTien * laiSuatThang;

                tongTien += tienLaiThang;

                Console.WriteLine($"{thang}\t{tongTien.ToString("N0")}\t\t{tienLaiThang.ToString("N0")}");
            }

            // In tổng tiền sau khi hết kỳ gửi
            Console.WriteLine($"\nTổng tiền sau {soThang} tháng là: {tongTien.ToString("N0")}");
        }
    }
}
