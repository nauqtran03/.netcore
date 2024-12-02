using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bttl_3_4
{
    internal class Utility
    {
        // Don't use ref
        public void SwapFake (int x, int y)
        {
            int tg = x;
            x = y;
            y = tg;
        }
        // Use ref for parameter
        public void SwapReally(ref int x,ref int y)
        {
            int tg = x;
            x = y;
            y = tg;
        }
        // Use out for parameter
        public void AreaCircle (double radius, out double erea)
        {
            erea = 2* Math.PI* radius;
        }
    }
}
