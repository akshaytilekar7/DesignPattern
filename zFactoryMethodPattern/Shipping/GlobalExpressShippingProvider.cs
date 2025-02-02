
using FactoryMethodPattern.Commerce;

namespace FactoryMethodPattern.Shipping
{
    public class GlobalExpressShippingProvider : ShippingProvider
    {
        public override string GenerateShippingLabelFor(Order order)
        {
            return "GLOBAL-EXPRESS";
        }

    }
}
