using StrategyPattern.Business.Strategies.SalesTax;

namespace StrategyPattern.Business.Models
{
    interface IOrder
    {
        decimal GetTax(ISalesTaxStrategy salesTaxStrategy);
    }
}
