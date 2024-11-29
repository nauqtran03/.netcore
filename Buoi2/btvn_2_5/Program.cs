using System.Text;

namespace btvn_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập độ dài canh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài canh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài canh c: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a +c > b && b+c>a)
            {
                Console.WriteLine("Ba canh này tạo thành 1 tam giác");
                if (a == b && b == c)
                {
                    Console.WriteLine("Đây là tam giác đều.");
                }
                else if(a==b || a==c|| b == c)
                {
                    Console.WriteLine("Đây là tam giác cân.");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("Đây là tam giác vuông.");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường");
                }
            }
            else
            {
                Console.WriteLine("Ba cạnh này không tạo nên một tam giác.");
            }
        }
    }
}
