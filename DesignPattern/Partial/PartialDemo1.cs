using System;

namespace DesignPattern.Partial
{
    public partial class Circle
    {
        public void NewArea(int a)
        {
            Area(a);
        }

        partial void Area(int radius)
        {
            var x = radius * 10;
            Console.WriteLine("Area is : {0}", x);
        }
    }

    public class Test
    {
        Circle p = new Circle();

        public Test()
        {
            p.NewArea(6);
        }
    }
}
