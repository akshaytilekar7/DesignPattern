using System;

namespace DesignPattern.CSharp
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
