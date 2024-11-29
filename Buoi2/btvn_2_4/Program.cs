using System.Text;

namespace btvn_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Các số có tổng 3 chữ số là chẵn là: ");
            for (int i = 100; i <= 999; i++) {
                int hangtram = i / 100;
                int hangchuc = (i / 10)%10;
                int hangdonvi = i % 10;

                int tong = hangchuc + hangdonvi + hangtram;

                if(tong %2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
