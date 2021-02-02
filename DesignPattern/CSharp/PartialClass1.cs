using System;

public class Test1
{
    const int x = 10;
    public const int x1 = 10;

}

public class U
{

    public U()
    {
        Test1.x1
    }
}
namespace DesignPattern.CSharp
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
        readonly Circle p = new Circle();
        public Test()
        {
            p.NewArea(6);
        }
    }
}
