using System.Collections;

namespace lab_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Product("A", "5.78", 3));
            arrayList.Add(new Product("B", "5.0", 8));
            arrayList.Add(new Product("C", "6.9", 6));
            arrayList.Add(new Product("D", "5.8", 1));

            Console.WriteLine("Product list: ");
            foreach (Product i in arrayList)
            {
                Console.WriteLine("   "+ i);
            }
        }
    }
}
