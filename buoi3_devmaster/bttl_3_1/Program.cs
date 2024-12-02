namespace bttl_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.make = "Toyota";
            car.model = "Land Cuiser";
            car.color = "Black";
            car.year = 2024;

            Console.WriteLine("Thong tin chi tiet: ");
            Console.WriteLine($"Make: {car.make}");
            Console.WriteLine($"Model: {car.model}");
            Console.WriteLine($"Color: {car.color}");
            Console.WriteLine($"Year: {car.year}");

            car.Stop();
            car.Start();
        }
    }
}
