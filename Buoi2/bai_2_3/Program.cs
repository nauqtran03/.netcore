using System.Text;

namespace bai_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập biến a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập biển b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập biển c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Phương trình bậc hai là: {a}*x^2 + b*x + c = 0");
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Phương trình có nghiệm kép: x1=x2= {(double)(-b / 2 * a):F2}");
            }
            else {
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt:\n x1 = {(double)(-b + Math.Sqrt(delta)) / (2 * a):F2} \n x2 = {(double)(-b - Math.Sqrt(delta)) / (2 * a):F2}" );
            }
        }
    }
}
