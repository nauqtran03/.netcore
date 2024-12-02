namespace bttl_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studentmodel studentmodel = new Studentmodel();
            List<Student> list = studentmodel.getstudent();
            foreach (Student students in list)
            {
                students.Display();
            }
            Console.WriteLine("--------------------------------------");
            Student student = studentmodel.GetStudent(2);
            student.Display();
            Console.WriteLine("--------------------------------------");
            List<Student> list2 = studentmodel.GetStudent(18,20);
            foreach (var item in list2)
            {
                item.Display();
            }
        }
    }
}
