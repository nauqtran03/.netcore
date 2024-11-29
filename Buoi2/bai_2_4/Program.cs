using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;


namespace bai_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool check_i;
            int n = 100;
            for (int i = 2; i<n; i++)
            {
                check_i = true;
                for (int j = 2; j< i/2; j++)
                {
                    if (i % j  == 0)
                    {
                        check_i = false;
                        break;
                    }
                    
                }
                if (check_i)
                {
                    Console.Write($" {i}");
                }
            }
            Console.ReadLine();
        }
    }
}
