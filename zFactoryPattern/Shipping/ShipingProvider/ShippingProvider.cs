using zFactoryPattern.Commerce;

namespace zFactoryPattern.Shipping.ShipingProvider
{
    public abstract class ShippingProvider
    {
        public CostCaluculate ShippingCostCalculator { get; protected set; }
        public TaxOptions TaxOptions { get; set; }
        public abstract string GenerateShippingLabelFor(Order order);
    }

    public class CostCaluculate
    {
        private readonly decimal internationalShippingFee;
        private readonly decimal extraWeightFee;

        public ShippingType ShippingType { get; set; }

        public CostCaluculate(decimal internationalShippingFee, decimal extraWeightFee, ShippingType shippingType = ShippingType.Standard)
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
