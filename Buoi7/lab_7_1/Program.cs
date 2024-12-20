using Store;

namespace lab_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            dealer.Name = "Tran Quang Quan";
            dealer.Email = "quanxylaga1611@gmail.com";
            dealer.Phone = "0376219421";
            Console.WriteLine("Dealer information: ");
            Console.WriteLine($"Name: {dealer.Name} \t Email: {dealer.Email} \t Phone: {dealer.Phone}");

            StoreItem st = new StoreItem();
            st.ItemNo = 1;
            st.ItemName = "Phao Hoa";
            st.Price = 100;
            Console.WriteLine("Store Inventory: ");
            Console.WriteLine($"Item: {st.ItemNo} \t Item Name: {st.ItemName} \t Price: {st.Price}");
        }
    }
}
