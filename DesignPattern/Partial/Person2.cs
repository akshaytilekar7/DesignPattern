using System;

namespace DesignPattern.Partial
{
    public partial class Circle
    {
        partial void Area(int radius);

        public void Display()
        {
            Console.WriteLine("Example of partial method");
        }
    }
}
