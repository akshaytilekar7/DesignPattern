using System;
using FactoryMethodPattern.Commerce;

namespace FactoryMethodPattern.Shipping
{
    public class SwedishSP : ShippingProvider
    {
        private readonly string apiKey;

        public SwedishSP(string apiKey, CostCalculate shippingCostCalculator, TaxOptions taxOptions)
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
