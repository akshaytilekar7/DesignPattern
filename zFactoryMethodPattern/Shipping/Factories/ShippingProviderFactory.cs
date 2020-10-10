namespace zFactoryMethodPattern.Shipping.Factories
{
    interface IShippingProviderFactory
    {
        ShippingProvider CreateShippingProvider(string country);  //public abstract 

    }

    //public abstract class ShippingProviderFactory
    //{
    //    public abstract ShippingProvider CreateShippingProvider(string country);

    //    public ShippingProvider GetShippingProvider(string country)
    //    {
    //        var provider = CreateShippingProvider(country);

    //        if (country == "Sweden")
    //            provider.RequireSignature = false;

    //        return provider;
    //    }
    //}
}
