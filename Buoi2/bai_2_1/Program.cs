using Microsoft.VisualBasic;
using System.Text;

namespace bai_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập mã sinh viên: ");
            string ma = Console.ReadLine();
            Console.Write("Nhập tên sinh viên: ");
            string ten = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            DateTime ngaysinh;
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhập điểm ba môn: ");
            Console.Write("Môn thứ 1: ");
            double diem1 = Double.Parse(Console.ReadLine());
            Console.Write("Môn thứ 2: ");
            double diem2 = Double.Parse(Console.ReadLine());
            Console.Write("Môn thứ 2: ");
            double diem3 = Double.Parse(Console.ReadLine());
            double dtb = (diem1 + diem2 + diem3) / 3;
            Console.WriteLine("-----THÔNG TIN SINH VIÊN VỪA NHẬP LÀ--------");
            Console.WriteLine($"Mã sinh viên: {ma},\n Tên sinh viên: {ten},\n Ngày sinh: {ngaysinh:dd/MM/yyyy},\n Điểm trung bình: {dtb:F2}");
        }
    }
}
