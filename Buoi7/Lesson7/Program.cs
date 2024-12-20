
using Electronic.Sony;
using samsung = Electronic.Samsung;
namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cách 1: Dùng using gọi tới class
            Xperia xperia = new Xperia();
            //Cách 2: Dùng class gọi trực tiếp
            Electronic.Sony.Xperia xperia1 = new Xperia();
            //Cách 3: Dùng alias-bí danh
            samsung.GalaxyA galaxyA = new samsung.GalaxyA(); 
        }
    }
}
