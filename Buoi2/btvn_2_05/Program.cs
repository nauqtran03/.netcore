using System.Text;

namespace btvn_2_05
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int i = 1;
            Console.Write("Nhập vào số dòng: ");
            int n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------");
            for (i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------");
            for ( i = 1; i <= n; i++) 
            {
                
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

               
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); 
            }

        }
    }
}
