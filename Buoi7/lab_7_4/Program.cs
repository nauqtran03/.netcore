namespace lab_7_4
{
    internal class InvalidInputNumber : Exception
    {
        public InvalidInputNumber() : base("Hay nhap 1 so lon hon 0") { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.WriteLine("Nhap 1 so: ");
            try
            {
                intNum = int.Parse(Console.ReadLine());
                if (intNum < 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch (InvalidInputNumber obInvalidInput)
            {
                Console.WriteLine(obInvalidInput.Message);
            }
            catch (System.FormatException obInvalidInput)
            {
                Console.WriteLine(obInvalidInput.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    Console.WriteLine("Day so sau khi nhap: ");
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                    {
                        Console.WriteLine(intCnt * intNum);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
