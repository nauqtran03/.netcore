namespace bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category category = new Category();
            category.ID = 1;
            category.Name = "Test";
            category.Display();

            Console.WriteLine($"Mã: {category.ID}\t  Tên: {category.Name}");

            Employee employee = new Employee();


            Student student = new Student();
            student.Id = 1;
            student.Name = "Quân";
            student.Mark1 = 7;
            student.Mark2 = 8;
            student.Mark3 = 9;
            student.Display();
            double sum = student.Average();
            Console.WriteLine(sum);
            

            TestTinh.Id = 16;
            TestTinh.Name = "Quân";
            TestTinh.Display();

            int a = 20; int b = 21;
            double area;
            Number.Swap(a, b);
            Console.WriteLine($"a: {a}, b: {b}");

            Number.Swap(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");

            Number.Cal(out area, 2);
            Console.WriteLine($"area: {area}");

            Console.ReadLine();
        }
    }
}
