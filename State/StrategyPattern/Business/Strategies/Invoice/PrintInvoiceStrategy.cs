using StrategyPattern.Business.Models;
using System;

namespace StrategyPattern.Business.Strategies.Invoice
{
    public class PrintInvoiceStrategy : IInvoiceStrategy
    {
        public void Generate(Order order)
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
