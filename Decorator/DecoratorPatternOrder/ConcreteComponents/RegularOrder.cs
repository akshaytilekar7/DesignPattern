using DecoratorPatternOrder.Component;
using System.Collections.Generic;

namespace DecoratorPatternOrder.ConcreteComponents
{
    public class RegularOrder : IOrderService
    {
        public string CalculateTotalOrderPrice(List<Product> products)
        {
            return nameof(RegularOrder);
        }
    }
}
