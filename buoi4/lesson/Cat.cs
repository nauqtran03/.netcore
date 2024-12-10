using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Cat:Animal
    {
        
        public void Action()
        {
            Eat();
            DoSomething();
        }
        public void Show()
        {
            food = "Cá";
            activity = "Cào";
            Console.WriteLine($"Méo ăn: {food}");
            Console.WriteLine($"Mèo đang: {activity}");
        }
    }
}
