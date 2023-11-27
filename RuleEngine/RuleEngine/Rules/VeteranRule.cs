using RuleEngine.Contracts;
namespace RuleEngine.Rules
{
    public class VeteranRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
        {
            if (customer.IsVegiterian)
                return .10m;
            return 0;
        }
    }
}
