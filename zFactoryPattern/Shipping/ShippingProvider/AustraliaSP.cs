using System;
using FactoryPattern.Commerce;

namespace FactoryPattern.Shipping.ShippingProvider
{
    public class AustraliaSP : ShippingProviderCls
    {
        private readonly string clientId;
        private readonly string secret;

        public AustraliaSP(string clientId, string secret, CostCalculate shippingCostCalculator, TaxOptions taxOptions)
        {
            this.clientId = clientId;
            this.secret = secret;

            ShippingCostCalculator = shippingCostCalculator;
            TaxOptions = taxOptions;
        }

        public override string GenerateShippingLabelFor(Order o)
        {
            if (o.Recipient.Country != o.Sender.Country)
                throw new NotSupportedException("International shipping not supported");

            var shippingCost = ShippingCostCalculator.GetCost(o.Recipient.Country, o.Sender.Country, o.TotalWeight);

            return $"Shipping Id: AUS-{Guid.NewGuid()} {Environment.NewLine}" +
                    $"To: {o.Recipient.To} {Environment.NewLine}" +
                    $"Order total: {o.Total} {Environment.NewLine}" +
                    $"Tax: {TaxOptions} {Environment.NewLine}" +
                    $"Shipping Cost: {shippingCost}";
        }

    }
}
