using System.Text;

namespace bai_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string[] name = { "Quân", "Ngân", "Huy", "Phong" };
            Console.WriteLine("Danh sách sinh viên: ");
            foreach (var n in name)
            {
                Console.WriteLine(n);
            }
        }
    }
}
