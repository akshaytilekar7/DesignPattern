
using zFactoryMethodPattern.Commerce;

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
