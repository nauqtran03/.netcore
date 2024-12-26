using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi9
{
    internal class TacGia
    {
        public int Id {  get; set; }
        public string TenTacGia { get; set; }

        public TacGia() { }
        public TacGia(int Id, string TenTacGia) 
        {
            this.Id = Id;
            this.TenTacGia = TenTacGia;
        }
        public void Nhap_TacGia()
        {
            Console.Write("Nhap id tac gia: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten tac gia: ");
            TenTacGia = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Id tac gia: {Id}, Ten Tac Gia: {TenTacGia}";
        }
    }
}
