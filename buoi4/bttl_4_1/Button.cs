using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bttl_4_1
{
    internal class Button:Window
    {
        public Button() { }
        public Button(int top, int left):base(top,left)
        {

        }
        public override void DrawWindow()
        {
            Console.WriteLine($"Drawing window at: {top}, {left}");
        }
    }
}
