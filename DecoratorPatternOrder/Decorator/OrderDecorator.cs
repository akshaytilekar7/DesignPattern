using DecoratorPatternOrder.Component;
using System;

namespace DecoratorPatternOrder.Decorator
{
    public class OrderDecorator : Order
    {
        protected Order Order;

        public OrderDecorator(Order order)
        {
            this.Order = order;
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in a decorator class");
            return Order.CalculateTotalOrderPrice();
        }
    }
}
