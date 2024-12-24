
namespace lab_8_3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 3,5,23,26,6,1,7,32,9};
            string[] Words = { "Chi","trich","phe","phan","nguoi","khac","giong",
            "nhu","con","chim","bo","cau","dua","thu","bao","gio","cung","quay","ve","noi","xuat","phat"};
            List<Film> films = new List<Film>()
            {
                new Film("F01","Diep vien 007",100000),
                new Film("F02","Tam quoc dien nghia",140000),
                new Film("F03","Nguoi nhen 2",149000),
                new Film("F04","Ngan hang tinh yeu",304000),
                new Film("F05","Nguoi dep va quai thu",560000),
            };
            //Loc cac so chan
            IEnumerable<int> queryNum = Numbers.Where(num => num % 2 == 0);
            Show<int>(queryNum, "Filter the numbers");
            //Loc cac tu co do dai > 4
            IEnumerable<string> queryWord = Words.Where(w => w.Length > 4);
            Show<string>(queryWord, "Filter words longer than 4");
            //Loc cac tu co ten bat dau bang chu t
            IEnumerable<string> queryWord1 = Words.Where(w => w.StartsWith("t"));
            Show<string>(queryWord1, "Filter words start with t");
        }
        static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
