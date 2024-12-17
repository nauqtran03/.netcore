using System;
using System.Collections;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            //arrayList.Add("Quân");
            int[] arr = new int[7] {13,23,34,45,55,62,71 };
            arrayList.AddRange(arr);
            Console.WriteLine("Chuỗi array: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine("==================================");
            arrayList.Sort();
            Console.WriteLine("Chuỗi sau khi sắp xếp: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            arrayList.RemoveAt(1);
            Console.WriteLine("Chuỗi sau khi xóa: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            arrayList.Remove(13);
            Console.WriteLine("Chuỗi sau khi xóa phần tử có giá trị 13: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            arrayList.RemoveRange(4,2);
            Console.WriteLine("Chuỗi sau khi xóa phần tử có giá trị thứ 4 và 5: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add("IT", "Information Tecnology");
            hashtable.Add("MK", "Marketing");
            hashtable["QQ"] = "Quang Quân";

            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("Key: "+key+" Value: "+hashtable[key]);
            }
            SortedList sortedList = new SortedList();
            sortedList.Add("IT", "Information Tecnology");
            sortedList.Add("MK", "Marketing");
            sortedList["QQ"] = "Quang Quân";
            for (int i = 0; i < sortedList.Count; i++) { 
                Console.WriteLine("Index: "+sortedList.GetKey(i)+ " Value"+ sortedList.GetByIndex(i));
            }
            sortedList.Remove("IT");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("Index: " + sortedList.GetKey(i) + " Value" + sortedList.GetByIndex(i));
            }
            List<string> list = new List<string>() { "Trần"," Quang"," Quân"};
            for (int i = 0; i < list.Count; i++) 
            {
                Console.Write(list[i]);
            }
        }
    }
}
