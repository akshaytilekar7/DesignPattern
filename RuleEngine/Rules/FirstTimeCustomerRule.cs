using RuleEngine.Contracts;
namespace RuleEngine.Rules
{
    public class FirstTimeCustomerRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
        {
            if (!customer.DateOfFirstPurchase.HasValue)
                return .15m;
            return 0;
        }
    }
}
