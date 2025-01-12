namespace btvn_bai1.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; }
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
        
        public Account(int id, string name, string email, string phone, string avatar, string address, string bio, int gender, DateTime birthday)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Avatar = avatar;
            Address = address;
            Bio = bio;
            Gender = gender;
            Birthday = birthday;
        }
    }
}
