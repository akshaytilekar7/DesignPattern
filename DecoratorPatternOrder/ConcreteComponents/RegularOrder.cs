using DecoratorPatternOrder.Component;
using System;
using System.Linq;

namespace DecoratorPatternOrder.ConcreteComponents
{
    public class RegularOrder : Order
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a regular order");
            return Products.Sum(x => x.Price);
        }
    }
}
