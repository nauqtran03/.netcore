namespace lab_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Business.House house = new Business.House();
            house.HouseNo = "QUAN123";
            house.Price = 100000;
            Console.WriteLine("House Information: ");
            Console.WriteLine($"House: {house.HouseNo} \t Price: {house.Price}");

            Dealership.Car car = new Dealership.Car();
            car.CarNo = "1AF321";
            car.Price = 100231;
            Console.WriteLine("Car Information: ");
            Console.WriteLine($"Car: {car.CarNo} \t Price: {car.Price}");
        }
    }
}
