using DecoratorPatternOrder.Component;
using DecoratorPatternOrder.Decorator;
using System;
using System.Linq;

namespace DecoratorPatternOrder.ConcreteDecorators
{
    public class PreOrder : OrderDecorator
    {
        public PreOrder(Order order) : base(order)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a preOrder.");
            return Products.Sum(x => x.Price) + 100;
        }
    }
}
