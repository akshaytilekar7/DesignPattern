using DecoratorPatternOrder.Component;
using System;
using System.Linq;

namespace DecoratorPatternOrder.ConcreteComponents
{
    public class PreOrder : Order
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a preOrder.");
            return Products.Sum(x => x.Price) + 100;
        }
    }
}
