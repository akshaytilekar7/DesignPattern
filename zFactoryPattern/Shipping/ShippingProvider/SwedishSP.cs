using System;
using FactoryPattern.Commerce;

namespace FactoryPattern.Shipping.ShippingProvider
{
    public class SwedishSp : ShippingProviderCls
    {
        private readonly string apiKey;

        public SwedishSp(string apiKey, CostCalculate shippingCostCalculator, TaxOptions taxOptions)
        {
            this.apiKey = apiKey;

            ShippingCostCalculator = shippingCostCalculator;
            TaxOptions = taxOptions;
        }

        public override string GenerateShippingLabelFor(Order o)
        {
            var shippingCost = ShippingCostCalculator.GetCost(o.Recipient.Country, o.Sender.Country, o.TotalWeight);

            return $"Shipping Id: {$"SWE-{Guid.NewGuid()}" } {Environment.NewLine}" +
                    $"To: {o.Recipient.To} {Environment.NewLine}" +
                    $"Order total: {o.Total} {Environment.NewLine}" +
                    $"Tax: {TaxOptions} {Environment.NewLine}" +
                    $"Shipping Cost: {shippingCost}";
        }


    }
}
