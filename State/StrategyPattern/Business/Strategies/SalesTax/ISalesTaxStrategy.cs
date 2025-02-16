using StrategyPattern.Business.Models;

namespace StrategyPattern.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        decimal GetTaxFor(Order order);
    }
}
