namespace RuleEngine.Contracts
{
    public interface IDiscountRule
    {
        decimal CalculateDiscount(Customer customer, decimal currentDiscount);
    }
}
