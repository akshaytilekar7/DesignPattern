using RuleEngine.Contracts;
namespace RuleEngine.Rules
{
    public class LoyalCustomerRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
        {
            if (customer.DateOfFirstPurchase.HasValue)
            {
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-15))
                    return .15m;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-10))
                    return .12m;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-5))
                    return .10m;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-2))
                    return .08m;
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-1))
                    return .05m;
            }
            return 0;
        }
    }
}
