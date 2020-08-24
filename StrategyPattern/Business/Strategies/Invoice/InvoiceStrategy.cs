using StrategyPattern.Business.Models;
using System;
using System.Globalization;

namespace StrategyPattern.Business.Strategies.Invoice
{
    public abstract class InvoiceStrategy : IInvoiceStrategy
    {
        public abstract void Generate(Order order);

        public string GenerateTextInvoice(Order order)
        {
            return Convert.ToString(order.TotalPrice, CultureInfo.InvariantCulture);
        }
    }
}
