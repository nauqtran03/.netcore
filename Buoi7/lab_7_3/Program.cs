namespace lab_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[6];
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine($"data[{i + 1}]= ");
                    data[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex) {
                Console.WriteLine("Khong duoc nhap ki tu cho mang so.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-255");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }
            Console.WriteLine("Mang: ");
            for (int i = 0; i <= 5; i++) {
                Console.WriteLine($"{data[i]}");
            }
        }
    }
}
