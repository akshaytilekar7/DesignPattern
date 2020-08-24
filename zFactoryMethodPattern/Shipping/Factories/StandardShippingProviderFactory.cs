using System;
using zFactoryPattern.Shipping.ShipingProvider;

namespace zFactoryMethodPattern.Shipping.Factories
{
    public class StandardShippingProviderFactory : IShippingProviderFactory
    {
        public ShippingProvider CreateShippingProvider(string country) //override
        {
            ShippingProvider shippingProvider;

            #region Create Shipping Provider

            switch (country)
            {
                case "Australia":
                    {
                        #region Australia Post Shipping Provider
                        var shippingCostCalculator = new CostCaluculate(250, 500)
                        {
                            ShippingType = ShippingType.Standard
                        };

                        shippingProvider = new AustraliaSP("CLIENT_ID", "SECRET", shippingCostCalculator,
                            TaxOptions.PrePaid);
                        break;
                        #endregion
                    }

                case "Sweden":
                    {
                        #region Swedish Postal Service Shipping Provider
                        var shippingCostCalculator = new CostCaluculate(50, 100)
                        {
                            ShippingType = ShippingType.Express
                        };

                        shippingProvider = new SwedishSP("API_KEY", shippingCostCalculator, TaxOptions.PayOnArrival);
                        break;
                        #endregion
                    }

                default:
                    throw new NotSupportedException("No shipping provider found for origin country");
            }
            #endregion

            return shippingProvider;
        }
    }
}
