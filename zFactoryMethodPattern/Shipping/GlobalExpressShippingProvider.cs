
using zFactoryMethodPattern.Commerce;
using zFactoryPattern.Shipping.ShipingProvider;

namespace zFactoryMethodPattern.Shipping
{
    public class GlobalExpressShippingProvider : ShippingProvider
    {
        public override string GenerateShippingLabelFor(Order order)
        {
            return "GLOBAL-EXPRESS";
        }

    }
}
