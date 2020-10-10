namespace zFactoryMethodPattern.Shipping.Factories
{
    public class GlobalExpressShippingProviderFactory : IShippingProviderFactory
    {
        public ShippingProvider CreateShippingProvider(string country) //override
        {
            return new GlobalExpressShippingProvider();
        }
    }
}
