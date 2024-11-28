using System.Text;

namespace bai_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số điện trên công tơ: ");
            int sodien = int.Parse(Console.ReadLine());
            if(sodien <= 30)
            {
                Console.WriteLine($"Số điện đã dùng là: {sodien}");
                Console.WriteLine("Cước phí của bạn là 30$.");
            }
            else if(sodien>30 && sodien <= 50)
            {
                Console.WriteLine($"Số điện đã dùng là: {sodien}");
                Console.WriteLine($"Cước phí là: {30+(sodien-30)*1.2}$ ");
            }
            else
            {
                Console.WriteLine($"Số điện đã dùng là: {sodien}");
                Console.WriteLine($"Cước phí là: {30 + (50 - 30) * 1.2 + (sodien - 50) * 1.5}$ ");
            }
        }
    }
}
