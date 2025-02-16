using DecoratorPatternOrder.Component;
using DecoratorPatternOrder.Decorator;
using System;
using System.Collections.Generic;

namespace DecoratorPatternOrder.ConcreteDecorators
{
    public class PremiumPreOrder : OrderDecorator
    {
        private readonly IOrderService order;

        public PremiumPreOrder(IOrderService order) : base(order)
        {
            this.order = order;
        }
        public override string CalculateTotalOrderPrice(List<Product> products)
        {
            //Console.WriteLine($"Calculating the total price in the {nameof(PremiumPreOrder)} class.");
            //Console.WriteLine("Adding additional charges to a preOrder price");
            return nameof(PremiumPreOrder) + " " + base.CalculateTotalOrderPrice(products);
        }
    }
}
