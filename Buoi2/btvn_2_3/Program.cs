using System.Text;

namespace btvn_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số giây: ");
            int sogiay = int.Parse(Console.ReadLine());

            int gio = sogiay / 3600;
            int phut = (sogiay % 3600)/60;
            int giay = sogiay % 60;
            Console.Write("Hiển thị ra sau khi chuyển đổi: ");
            Console.WriteLine($"{gio:D2}:{phut:D2}:{giay:D2}");
        }
    }
}
