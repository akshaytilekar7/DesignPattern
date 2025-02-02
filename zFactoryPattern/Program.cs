using System;
using FactoryPattern.Commerce;
using FactoryPattern.Shipping;

namespace FactoryPattern
{
    class Program
    {
        // ADVANTAGE SIMPLE FACTORY 
        // 1. ShippingProviderFactory is REUSABLE
        // 2. we can use same class in TEST and actual application (don't need to create separate object for test)
        // 3. application DON'T NEED TO CARE ABOUT CREATION OF OBJECT

        // DISADVANTAGES
        // 1. NOT EXTENDABLE eg. for INDIA shipping we need to modified to this class which s wrong
        // USE FACTORY METHOD PATTERN

        static void Main(string[] args)
        {
            var aus = "Australia";
            var swe = "Sweden";

            #region Create Order
            var recipientCountry = aus;
            var senderCountry = aus;
            var totalWeight = 10;

            var order = new Order
            {
                Recipient = new Address { To = "Filip Ekberg", Country = recipientCountry },
                Sender = new Address { To = "Someone else", Country = senderCountry },
                TotalWeight = totalWeight
            };

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m), 1);
            #endregion

            //var cart = new ShoppingCart(order);
            //var shippingLabel = cart.Finalize();

            var shippingProvider = new ShippingProviderFactory().CreateShippingProvider(order.Sender.Country);
            order.ShippingStatus = ShippingStatus.ReadyForShippment;
            var shippingLabel = shippingProvider.GenerateShippingLabelFor(order);

            Console.WriteLine(shippingLabel);
            Console.ReadLine();

        }
    }
}
