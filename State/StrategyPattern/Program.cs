using StrategyPattern.Business.Models;
using StrategyPattern.Business.Strategies.Invoice;
using StrategyPattern.Business.Strategies.SalesTax;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails
                {
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                },
            };

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m, ItemType.Service), 1);

            order.SelectedPayments.Add(new Payment()
            {
                PaymentProvider = PaymentProvider.Invoice
            });
            Console.WriteLine(order.GetTax(new SwedishSalesTaxStrategy())); // RELATE IT TO FACTORY
            order.InvoiceStrategy = new FilelInvoiceStrategy();
            order.FinalizeOrder();
        }
    }
}
