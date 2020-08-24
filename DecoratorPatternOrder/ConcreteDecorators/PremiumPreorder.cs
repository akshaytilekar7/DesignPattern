using DecoratorPatternOrder.Component;
using DecoratorPatternOrder.Decorator;
using System;

namespace DecoratorPatternOrder.ConcreteDecorators
{
    public class PremiumPreOrder : OrderDecorator
    {
        public PremiumPreOrder(Order order) : base(order)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in the {nameof(PremiumPreOrder)} class.");
            var preOrderPrice = base.CalculateTotalOrderPrice();

            Console.WriteLine("Adding additional charges to a preOrder price");
            return preOrderPrice + 50;
        }
    }
}
