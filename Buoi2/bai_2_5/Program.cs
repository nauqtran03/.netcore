using System.Text;

namespace bai_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            for (int i = 1; i<100; i++)
            {
                if(i%2==0 && i % 3 != 0)
                {
                    tong += i;
                }
            }
            Console.WriteLine($"Tổng các số chẵn nhỏ hơn 100 và chia 3 dư 1 là: {tong}");
        }
    }
}
