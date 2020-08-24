using System;
using zFactoryMethodPattern.Commerce;
using zFactoryMethodPattern.Shipping.Factories;

namespace zFactoryMethodPattern
{
    class Program
    {
        // 1. seaprate client from creation of object
        // 2. ALLOW MORE FLEXIBLE AND EXTENSIBLE
        // 3. application only care about instance of ShippingProviderFactory and not care about EXACTLY WHICH shipping Provider it uses

        // DIFF :
        // simple factory has all decision inside its method only, whereas in this pattern
        // CREATOR CAN OVERRIDE default factory method implmentations

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
            order.ShippingStatus = ShippingStatus.ReadyForShippment;

            //var cart = new ShoppingCart(order, new StandardShippingProviderFactory());
            //var shippingLabel = cart.Finalize();

            IShippingProviderFactory factory = null;

            // OUT OF STATE TRANSPORT
            if (order.Recipient != order.Sender)
                factory = new GlobalExpressShippingProviderFactory();
            else
                factory = new StandardShippingProviderFactory();

            var obj = factory.CreateShippingProvider(order.Sender.Country);

            var shippingLabel = obj.GenerateShippingLabelFor(order);

            Console.WriteLine(shippingLabel);
            Console.ReadLine();

        }
    }
}
