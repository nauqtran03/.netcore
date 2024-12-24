namespace lab_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cus = new Customer[]
            {
                new Customer(1,"Tran Quang Quan"),
                new Customer(2,"Le Thi Ngan"),
                new Customer(3,"Nguyen Van A"),
                new Customer(4,"Le Thi B")
            };
            var order = new Order[]
            {
                new Order(1,"Game"),
                new Order(2,"Book"),
                new Order(3,"Computer"),
                new Order(4,"Shirt"),
            };
            var query = from m in cus join o in order on m.Id equals o.Id select new {m.Name, o.Product};
            Console.WriteLine("Display name customer and product");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name} bought {item.Product}");
            }
        }
    }
}
