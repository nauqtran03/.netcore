using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass {  get; set; }
        public float[] MarkList = new float[3];
        public float StudAvgMark {
            get {
                return MarkList.Average();
            }
        }
        public void Print()
        {
            Console.WriteLine($"Student Id: {StudID} \n Student Name: {StudName} \n Student Gender: {StudGender} \n Student Age: {StudAge} \n Student Class: {StudClass} \n Student Avg Mark: {StudAvgMark:F2}");
        }
        public void CalAvg() 
        {
            Console.WriteLine("Nhap diem: ");
            for (int i = 0; i < MarkList.Length; i++) 
            {
                Console.Write($"Nhap diem thu {i + 1}: ");
                MarkList[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Diem da duoc tinh!");
        }
    }
}
