using System;
using DongVat.AnCo;
using DongVat.AnThit;

namespace DongVat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test các loài ăn cỏ
            var bo = new Bo(1, "Bò Vàng", 500.5);
            var trau = new Trau(2, "Trâu Đen", 700.3);
            var de = new De(3, "Dê Núi", 50.2);

            bo.DisplayInfo();
            trau.DisplayInfo();
            de.DisplayInfo();

            // Test các loài ăn thịt
            var caSau = new CaSau(4, "Cá Sấu Sông Nile", 250.8);
            var ho = new Ho(5, "Hổ Bengal", 190.4);
            var suTu = new SuTu(6, "Sư Tử Châu Phi", 210.6);

            caSau.DisplayInfo();
            ho.DisplayInfo();
            suTu.DisplayInfo();

            Console.ReadKey();
        }
    }
}