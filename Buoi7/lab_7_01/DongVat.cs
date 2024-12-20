using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat
{
    namespace AnCo
    {
        public class Bo
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public Bo(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Bo - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
            }
        }

        public class Trau
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public Trau(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Trau - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
            }
        }

        public class De
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public De(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"De - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
            }
        }
    }

    namespace AnThit
    {
        public class CaSau
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public CaSau(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"CaSau - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
            }
        }

        public class Ho
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public Ho(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Ho - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
            }
        }

        public class SuTu
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public SuTu(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"SuTu - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
            }
        }
    }
}
