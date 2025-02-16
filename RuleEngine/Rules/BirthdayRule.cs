using RuleEngine.Contracts;
namespace RuleEngine.Rules
{
    public class BirthdayRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
        {
            bool isBirthday = customer.DateOfBirth.HasValue && customer.DateOfBirth.Value.Month == DateTime.Today.Month && customer.DateOfBirth.Value.Day == DateTime.Today.Day;

            if (isBirthday) return currentDiscount + 0.10m;
            return currentDiscount;
        }
    }
}
