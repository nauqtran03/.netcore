namespace bttl_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            contact.Id = 16;
            contact.Firstname = "Quan";
            contact.Lastname = "Tran";
            contact.Address = "Thanh Hoa";
            contact.Phone = "0376219421";
            contact.Email = "quantranhk3@gmail.com";


            Contact contact1 = new Contact(11,"Ngan","Le","Thanh Hoa","0364566319","nganle@gmail.com");

            contact.Display();
            contact1.Display();
        }
    }
}
