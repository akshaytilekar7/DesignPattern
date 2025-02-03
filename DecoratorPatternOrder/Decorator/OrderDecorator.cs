using DecoratorPatternOrder.Component;
using System.Collections.Generic;

namespace DecoratorPatternOrder.Decorator
{
    public class OrderDecorator : IOrderService
    {
        protected IOrderService Order;

        public OrderDecorator(IOrderService order)
        {
            this.Order = order;
        }

        public virtual string CalculateTotalOrderPrice(List<Product> products)
        {
            return Order.CalculateTotalOrderPrice(products);
        }
    }
}
