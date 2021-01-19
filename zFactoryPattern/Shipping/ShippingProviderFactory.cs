using System;
using zFactoryPattern.Shipping.ShippingProvider;

namespace zFactoryPattern.Shipping
{
    public class ShippingProviderFactory
    {
        public static ShippingProviderCls CreateShippingProvider(string country)
        {
            ShippingProviderCls shippingProvider;

            switch (country)
            {
                case "Australia":
                    {
                        #region Australia Post Shipping Provider
                        var shippingCostCalculator = new CostCalculate(250, 500)
                        {
                            ShippingType = ShippingType.Standard
                        };

                        shippingProvider = new AustraliaSP("CLIENT_ID", "SECRET", shippingCostCalculator, TaxOptions.PrePaid);
                        break;
                        #endregion
                    }
                case "Sweden":
                    {
                        #region Swedish Postal Service Shipping Provider
                        var shippingCostCalculator = new CostCalculate(50, 100)
                        {
                            ShippingType = ShippingType.Express
                        };

                        shippingProvider = new SwedishSp("API_KEY", shippingCostCalculator, TaxOptions.PayOnArrival);
                        break;
                        #endregion
                    }
                default:
                    throw new NotSupportedException("No shipping provider found for origin country");
            }

            return shippingProvider;
        }
    }
}
