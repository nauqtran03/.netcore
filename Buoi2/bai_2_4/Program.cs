using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bai_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = 100;
            for (int i = 2; i<n; i++)
            {
                for (int j = i; j <= Math.Sqrt(i); j++)
                {
                    if (j % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                    
                }
                
            }
        }
    }
}
