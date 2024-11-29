using System.Text;

namespace btvn_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string id;
            string name;
            string address;
            DateTime birthday;
            double salary;
            double bonus;

            Console.Write("Nhập mã nhân viên: ");
            id = Console.ReadLine();
            Console.Write("Nhập tên nhân viên: ");
            name = Console.ReadLine();
            Console.Write("Nhập địa chỉ nhân viên: ");
            address = Console.ReadLine();
            Console.Write("Nhập ngày sinh nhân viên: ");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhập lương nhân viên: ");
            salary = Double.Parse(Console.ReadLine());
            Console.Write("Nhập thưởng nhân viên: ");
            bonus = Double.Parse(Console.ReadLine());
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Mã nhân viên: {id},\n Tên nhân viên: {name},\n Địa chỉ: {address},\n Ngày sinh: {birthday:dd/MM/yyyy},\n Lương: {salary},\n Thưởng: {bonus},\n Tổng tiền: {salary + bonus}");
        }
    }
}
