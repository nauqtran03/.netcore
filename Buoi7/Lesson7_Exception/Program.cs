using System.Data;

namespace Lesson7_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap gia tri a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri b: ");
            b = int.Parse(Console.ReadLine());
            string[] names = { "Quan", "Tran", "Quang" };
            try
            {
                Console.WriteLine("Khoi ngoai try catch");
                try
                {
                    c = b / a;
                    Console.WriteLine($"{b} / {a} = {c}");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine ("Khoi trong try catch");
                    Console.WriteLine (ex.Message);
                }
            }
            catch (Exception ex) {
                Console.WriteLine ("Khoi try catch ngoai");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
