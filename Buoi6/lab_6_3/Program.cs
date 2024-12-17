namespace lab_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();   
            list.Add(new Student("1","Tran","Quang Quan","Nam", 9.5));
            list.Add(new Student("2","Le","Thi Ngan","Nu", 9.1));
            list.Add(new Student("3","Tran","Quang Quan","Nam", 9.2));
            list.Add(new Student("4","Tran","Quang Quan","Nam", 9.3));
            Console.WriteLine("Student list: ");
            foreach (Student student in list)   
            {
                Console.WriteLine(student);
            }
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach (Student student in list)
            {
                if (student.Avg > max)
                {
                    max = student.Avg;
                    stmax = student;
                }
            }
            Console.WriteLine("\nStudent have mark maximum: ");
            Console.WriteLine(stmax);
        }
    }
}
