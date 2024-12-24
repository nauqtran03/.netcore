namespace lab_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "To", "ve", "hon", "nguoi", "se", "tro", "thanh", "ke", "thu", "cua", "ta", "Chiu", "nhuong", "nguoi", "thi", "nguoi", "se", "la", "ban", "cua", "ta" };
            IEnumerable<string> result = from m in data select m;
            Console.WriteLine("Display all result");
            foreach(var item in result)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine("===================================================");
            IEnumerable<string> result1 = from m in data where m.Equals("nguoi") select m;
            Console.WriteLine("query by style: ");
            foreach (var item in result1) {
                Console.WriteLine(item);    
            }
            Console.WriteLine();
            Console.WriteLine("===================================================");
            IEnumerable<string> result2 = from m in data orderby m select m;
            Console.WriteLine("Display all result arrange");
            foreach (var item in result2) { 
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================================");
            var result3 = from m in data select new {Thuong = m.ToLower(), Hoa = m.ToUpper()};
            Console.WriteLine("Display Thuong va Hoa: ");
            foreach(var item in result3)
            {
                Console.WriteLine(item.Thuong +":"+item.Hoa);
            }
        }
    }
}
