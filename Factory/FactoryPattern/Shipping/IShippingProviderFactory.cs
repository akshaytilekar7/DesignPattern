using FactoryPattern.Shipping.ShippingProvider;

namespace FactoryPattern.Shipping;

public interface IShippingProviderFactory
{
    ShippingProviderCls CreateShippingProvider(string country);
}