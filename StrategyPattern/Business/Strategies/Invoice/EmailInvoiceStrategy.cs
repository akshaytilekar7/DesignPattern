using StrategyPattern.Business.Models;
using System;

namespace StrategyPattern.Business.Strategies.Invoice
{
    public class EmailInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            var text = this.GenerateTextInvoice(order);

            // SEND EMAIL METHOD HTML AS 
            Console.WriteLine(this.GetType().Name + " " + text);
        }
    }
}
