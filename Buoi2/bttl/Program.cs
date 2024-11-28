using System.Diagnostics;
using System.Text;

namespace bttl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //khai báo biến
            //string name;
            //string address;

            ////in ra ngoài màn hình yêu cầu nhập tên

            //Console.WriteLine("Nhap ten cua ban: ");
            //name = Console.ReadLine();

            //Console.WriteLine("Nhap dia chi cua ban: ");
            //address = Console.ReadLine();

            //Console.WriteLine("Ten cua ban la: {0}\n" +
            //    "dia chi cua ban la: {1}", name,address);

            //Console.WriteLine($"Ten cua ban la: {name}\n" +
            //    $"dia chi cua ban la: {address}");

            //byte age;
            //age = 19;
            //int age2;
            //age2 = age;
            //Console.WriteLine("Age2: " + age2);

            //int diem;
            //diem = Convert.ToInt32(Console.ReadLine());
            //if (diem > 8)
            //{
            //    Console.WriteLine("Hoc sinh gioi");
            //}
            //else if (diem > 6)
            //{
            //    Console.WriteLine("Hoc sinh kha");
            //}
            //else if (diem > 4)
            //{
            //    Console.WriteLine("Hoc sinh trung binh");
            //}
            //else
            //{
            //    Console.WriteLine("Hoc sinh yeu");
            //}

            int thang;
            thang = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1:
                    Console.WriteLine("Thang 1.");
                    break;
                case 2:
                    Console.WriteLine("Thang 2.");
                    break;
                case 3:
                    Console.WriteLine("Thang 3.");
                    break;
                case 4:
                    Console.WriteLine("Thang 4.");
                    break;
                case 5:
                    Console.WriteLine("Thang 5.");
                    break;
                case 6:
                    Console.WriteLine("Thang 6.");
                    break;
                case 7:
                    Console.WriteLine("Thang 7.");
                    break;
                case 8:
                    Console.WriteLine("Thang 8.");
                    break;
                case 9:
                    Console.WriteLine("Thang 9.");
                    break;
                case 10:
                    Console.WriteLine("Thang 10.");
                    break;
                 default:
                    break;
            }
        }
    }
}
