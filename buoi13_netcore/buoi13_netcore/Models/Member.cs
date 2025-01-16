namespace buoi13_netcore.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public Member()
        {

        }
        public Member(int id, string name, string address, string city, string region)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            Region = region;
        }
    }
}
