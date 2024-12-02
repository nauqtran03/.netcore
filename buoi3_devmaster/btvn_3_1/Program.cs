namespace btvn_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Quan";
            employee.yearOfBirth = 2003;
            employee.salaryLevel = 3.4;
            employee.basicLevel = 1000000;

            employee.Display();
        }
    }
}
