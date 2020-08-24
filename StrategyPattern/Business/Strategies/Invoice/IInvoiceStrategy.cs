using StrategyPattern.Business.Models;

namespace StrategyPattern.Business.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        void Generate(Order order);
    }
}
