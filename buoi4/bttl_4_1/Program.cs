namespace bttl_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window(2,3);
            Button button = new Button(5,6);
            ListBox listBox = new ListBox(6,7,"Good Content");

            window.DrawWindow();
            button.DrawWindow();
            listBox.DrawWindow();

        }
    }
}
