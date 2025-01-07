namespace netcore_lesson1_mvc.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }

        public Product(string id, string name, string description, double? price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }    
    }
}
