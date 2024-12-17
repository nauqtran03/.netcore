namespace lab_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> list = new SortedList<string, string>();
            list.Add("A1", "Tran Quang Quan");
            list.Add("A2", "Le Thi Ngan");
            list.Add("A3", "Tran Quang Huy");
            list.Add("A4", "Nguyen Van A");

            Console.WriteLine("Employee list: ");
            foreach (var item in list.Keys) 
            {
                Console.WriteLine(item + ": " + list[item]);
            }
            Console.WriteLine("Employee list start by Th: ");
            foreach (var item in list.Keys)
            {
                if (list[item].StartsWith("Q"))
                {
                    Console.WriteLine(item + ": " + list[item]);
                }
            }
            list.Remove("A1");
            if (!list.ContainsKey("A5"))
            {
                list.Add("A5","Tran Quang Q");
            }
            Console.WriteLine("Danh sach sau khi xoa va them: ");
            foreach (var item in list.Keys) 
            {
                Console.WriteLine($"{item}: {list[item]}");
            }
        }
    }
}
