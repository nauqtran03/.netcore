using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bttl_4_1
{
    internal class ListBox:Window
    {
        protected string listBoxContent;

        public ListBox() { }
        public ListBox(int top, int left, string listBoxContent):base(top,left)
        {
            this.listBoxContent = listBoxContent;
        }
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine($"Writting to the listbox: {listBoxContent}");
        }
    }
}
