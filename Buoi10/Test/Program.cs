using System.Collections;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Hashtable studentHashtable = new Hashtable();
            int option =0;
            do
            {
                Console.WriteLine("Vui long chon 1 tuy chon: ");
                Console.WriteLine("==============================================");
                Console.WriteLine("\t 1.Them hoc sinh moi.");
                Console.WriteLine("\t 2.Hien thi toan bo hoc sinh.");
                Console.WriteLine("\t 3.Diem trung binh cua hoc sinh.");
                Console.WriteLine("\t 4.Thoat");
                Console.WriteLine("==============================================");
                try
                {
                    Console.Write("Nhap lua chon cua ban: ");
                    option = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex) 
                
                {
                    Console.WriteLine("Bạn nhập sai kiểu dữ liệu");
                }
               
                switch (option)
                {
                    case 1:
                        studentHashtable = InsertStudent( studentHashtable);
                        break;
                    case 2:
                        DisplayStudent(ref studentHashtable);
                        break;
                    case 3:
                        CalculatteMark(ref studentHashtable);
                        break;
                    case 4:
                        Console.WriteLine("Exiting....");
                        break;
                    default:
                        Console.WriteLine("Vui long lua chon phu hop");
                        break;
                }
            } while (option != 4);
        }
        static Hashtable InsertStudent ( Hashtable studentHashtable)
        {
            Student student = new Student();
            Console.Write("Nhap ID: ");
            student.StudID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            student.StudName = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            student.StudGender = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            student.StudAge = int.Parse(Console.ReadLine());
            Console.Write("Nhap lop: ");
            student.StudClass = Console.ReadLine();
            student.CalAvg();
            studentHashtable[student.StudID] = student;
            Console.WriteLine("Luu thanh cong");
            return studentHashtable;
        }
        static void DisplayStudent(ref Hashtable studentHashtable)
        {
            if (studentHashtable.Count == 0)
            {
                Console.WriteLine("Khong co ai o trong danh sach.");
            }
            else
            {
                foreach (Student student in studentHashtable.Values)
                {
                    student.Print();
                }
            }
        }
        static void CalculatteMark(ref Hashtable studentHashTable)
        {
            if (studentHashTable.Count == 0)
            {
                Console.WriteLine("Khong co hoc sinh trong lop hoc.");
                return;
            }
            while (true)
            {
                Console.Write("Nhap id hoc sinh muon tim kiem hoac nhap 'ex' neu ban muon thoat ra: ");
                string exit = Console.ReadLine();
                if (exit.ToLower() == "ex")
                {
                    Console.WriteLine("Quay tro lai menu");
                    break;
                }
                if ( int.TryParse(exit, out int id) && studentHashTable.ContainsKey(id))
                {
                    Student student = (Student)studentHashTable[id];
                    student.Print();
                    break;
                }
                else
                {
                    Console.WriteLine("Khong tim thay hoc sinh tren.");
                }
            }
        
        }
    }
}
