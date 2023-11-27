namespace RuleEngine.Contracts
{
    public class DiscountRuleEngineService
    {
        List<IDiscountRule> _rules = new List<IDiscountRule>();

        public DiscountRuleEngineService(IEnumerable<IDiscountRule> rules)
        {
            _rules.AddRange(rules);
        }

        public decimal CalculateDiscount(Customer customer)
        {
            decimal discount = 0m;
            foreach (var rule in _rules)
                discount = Math.Max(discount, rule.CalculateDiscount(customer, discount));
            return discount;
        }
    }
}
