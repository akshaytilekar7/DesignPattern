using FactoryMethodPattern.Commerce;

namespace FactoryMethodPattern.Shipping
{
    public abstract class ShippingProvider
    {
        public CostCalculate ShippingCostCalculator { get; protected set; }
        public TaxOptions TaxOptions { get; set; }
        public bool RequireSignature { get; internal set; }

        public abstract string GenerateShippingLabelFor(Order order);
    }

    public class CostCalculate
    {
        private readonly decimal internationalShippingFee;
        private readonly decimal extraWeightFee;

        public ShippingType ShippingType { get; set; }

        public CostCalculate(decimal internationalShippingFee, decimal extraWeightFee, ShippingType shippingType = ShippingType.Standard)
        {
            this.internationalShippingFee = internationalShippingFee;
            this.extraWeightFee = extraWeightFee;
            ShippingType = shippingType;
        }

        public decimal GetCost(string destinationCountry, string originCountry, decimal weight)
        {
            decimal total = 10m; // Default shipping cost $10

            // International shipping
            if (destinationCountry != originCountry)
                total += internationalShippingFee;

            // Over 5kg
            if (weight > 5)
                total += extraWeightFee;

            switch (ShippingType)
            {
                case ShippingType.Express: total += 20; break;
                case ShippingType.NextDay: total += 50; break;
            }

            return total;
        }
    }


}
