using DecoratorPatternOrder.Component;
using DecoratorPatternOrder.Decorator;
using System;
using System.Collections.Generic;

namespace DecoratorPatternOrder.ConcreteDecorators
{
    public class PreOrder : OrderDecorator
    {
        private readonly IOrderService order;

        public PreOrder(IOrderService order) : base(order)
        {
            this.order = order;
        }
        public override string CalculateTotalOrderPrice(List<Product> products)
        {
            return nameof(PreOrder) + " " + base.CalculateTotalOrderPrice(products);
        }
    }
}
