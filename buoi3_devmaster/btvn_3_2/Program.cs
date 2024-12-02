namespace btvn_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Tran Quang Quan", 50, "1231341sd", "Troi trong xanh", 30);
            book.Display();
            Console.Write("After page: ");
            book.flipPageForward();
            Console.Write("Before page: ");
            book.flipPageBackward();
            
        }
    }
}
