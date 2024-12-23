using System.Numerics;

namespace lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] cus =
            {
                new Customer(1,"Tran Quang Quan", "Thanh Hoa", 21),
                new Customer(2,"Tran Quang Huy", "Ha Noi", 25),
                new Customer(3,"Le Thi Ngan", "Thanh Hoa", 21),
                new Customer(4,"Tran Quang A", "Vinh Phuc", 16),
            };
            Province[] pro =
            {
                new Province("Ha Noi", 100000),
                new Province("Thanh Hoa", 143200),
                new Province("Hai Phong", 123400),
            };
            IEnumerable<Customer> listCustomer = from c in cus select c;
            foreach (var c in listCustomer)
            {
                Console.WriteLine(c.ToString());
            }

            IEnumerable<Customer> listCustomer1 = from c in cus where c.Age >= 19 & c.Age < 22 select c;
            foreach (var c in listCustomer1) {
                Console.WriteLine(c.ToString());
            }
            var list = from c in cus
                       join p in pro on c.City equals p.City
                       select new
                       {
                           c.Name,
                           c.City,
                           c.Age,
                           p.Capacity,
                       };
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name}\t {item.City}\t {item.Age}\t {item.Capacity}");

            }
            int[] numbers = { 1, 43, 7, 3, 2, 7, 9, 34, 5, 0, 454 };
            string[] words =
                {
                    "Chi","trich","phe","binh","nguoi","khac","giong","nhu","con","chim","bo","cau"
                };
            List<Film> list1 = new List<Film>()
            {
                new Film("ID1","Tay Du Ki", 1024000),
                new Film("ID2","When the phone ring", 100340),
                new Film("ID3","Khi dien thoai keu", 123000),
                new Film("ID4","Hong hae in", 100243),
            };

            var queryNumber = numbers.Distinct();
            Console.WriteLine("So phan tu trong queryNumber la: "+queryNumber.Count());
            var queryWord = words.Distinct().Count();
            Console.WriteLine("So phan tư trong queryWord la: "+queryWord);

            Console.WriteLine("Nam Phan tu dau tien trong mang la: ");
            var queryNumber1 = numbers.Take(5);
            foreach (var item in queryNumber1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nNam Phan tu dau tien trong mang sau khi bo 3 phan tu dau: ");
            var queryNumber2 = numbers.Take(5).Skip(3);
            foreach (var item in queryNumber2)
            {
                Console.WriteLine(item);
            }
            var query = list1.OrderByDescending(x => x.ID);
            foreach (var item in query)
            {
                Console.WriteLine(item.ID);
            }
            Console.WriteLine("So phan tu: "+query.Count());
        }
        internal class Film
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }

            public Film(string Id, string Name, int Price)
            {
                this.ID = Id;
                this.Name = Name;
                this.Price = Price;

            }
        }
    }
}
