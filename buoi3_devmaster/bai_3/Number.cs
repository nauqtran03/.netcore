using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Number
    {
        public static void Swap(int a, int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        public static void Swap(ref int a, ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }

        public static void Cal (out double area, double r)
        {
            area = 2 * 3.14 * r;
        }
    }
}
