﻿namespace FactoryMethodPattern.Shipping.Factories;

interface IShippingProviderFactory
{
    ShippingProvider CreateShippingProvider(string country);  //public abstract 
}
