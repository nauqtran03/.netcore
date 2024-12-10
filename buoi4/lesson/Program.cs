namespace lesson
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int tong = NapChong.Sum(1, 2);
            Console.WriteLine($"Tong cua 1 va 2 la: {tong}");
            double tong1 = NapChong.Sum(2.56, 4.56);
            Console.WriteLine($"Tong cua 2 so la: {tong1:F2}");
            int tong2 = NapChong.Add(5, 6);
            Console.WriteLine($"Tong cua 2 so la: {tong2}");
            int tong3 = NapChong.Add(7, 8, 9);
            Console.WriteLine($"Tong cua 3 so la: {tong3}");



            Student student = new Student();
            student.Id = 1;
            student.Name = "test";
            student.FirstName = "tran";
            student.Display();

            Student student2 = new Student(3,"Quan","Tran");
            student2.Display(); 


            Animal animal = new Animal();
            Cat cat = new Cat();
            cat.Action();
            cat.Show();


            Department department = new Department();
            department.Display();

            SalaryEmployee salaryEmployee = new SalaryEmployee("Quan", 200000);
            SalaryEmployee2 salaryEmployee2 = new SalaryEmployee2("Quan",20000,300000);
            salaryEmployee.CalPay();
            salaryEmployee2.CalPay();

            Console.WriteLine(salaryEmployee2.CalPay());
        }
    }
}
