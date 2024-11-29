using System.Text;

namespace btvn_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập năm: ");
            int nam = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            int thang = int.Parse(Console.ReadLine());

            int songay = 0;

            switch (thang)
            {
                case 1: case 3: case 5 : case 7:  case 8 : case 10: case 12:
                    songay = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    songay = 30;
                    break;

                case 2:
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                    {
                        songay = 29;
                    }
                    else 
                    {
                        songay = 28;
                    }
                    break;
                default:
                    Console.WriteLine("Tháng không hợp lệ: ");
                    return;

            }
            Console.WriteLine($"Năm: {nam}, Tháng: {thang}, Có: {songay} ngày");
        }
    }
}
