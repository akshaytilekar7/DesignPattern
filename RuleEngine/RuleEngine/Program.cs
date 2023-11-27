using RuleEngine;
using RuleEngine.Contracts;
using RuleEngine.Rules;

public class DiscountCalculator
{

    static void Main(string[] args)
    {
        var cust = new Customer()
        {
            DateOfBirth = new DateTime(1992, 08, 05),
            DateOfFirstPurchase = DateTime.Now.AddDays(-10),
            IsVegiterian = true,
        };

        Console.WriteLine("Total Discount " + CalculateDiscountPercentage(cust));
        Console.WriteLine("Hello World!");
    }

    public static decimal CalculateDiscountPercentage(Customer customer)
    {
        var ruleType = typeof(IDiscountRule);

        var rules = typeof(SeniorRule).Assembly.GetTypes()
            .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
            .Select(r => Activator.CreateInstance(r) as IDiscountRule);

        var engineRuleService = new DiscountRuleEngineService(rules);

        return engineRuleService.CalculateDiscount(customer);
    }
}