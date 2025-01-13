namespace btvn_bai2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime? Created { get; set; }
        
        public Product(int id, string name, double? price, string description, int status, DateTime? created)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Status = status;
            this.Created = created;
        }
    }
}
