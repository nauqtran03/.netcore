namespace bttl_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 30;
            double erea;
            Utility u = new Utility();
            Console.WriteLine("Before swap x={0}, y={1}", x,y);
            u.SwapFake(x, y);
            Console.WriteLine("After swap use SwapFake: x={0}, y={1}",x,y);
            u.SwapReally(ref x, ref y);
            Console.WriteLine("After swap use SwapReally: x={0}, y={1}",x,y);
            
            u.AreaCircle(100, out erea);
            Console.WriteLine("Chu vi hinh tron ban kinh 100 la: {0}", erea);
        }
    }
}
