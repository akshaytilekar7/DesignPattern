using System.Collections.Generic;

namespace DecoratorPatternOrder.Component
{
    public interface IOrderService
    {
        string CalculateTotalOrderPrice(List<Product> products);
    }
}
