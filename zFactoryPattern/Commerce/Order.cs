using System.Collections.Generic;
using System.Linq;

namespace zFactoryPattern.Commerce
{
    public class Order
    {
        public Dictionary<Item, int> LineItems { get; } = new Dictionary<Item, int>();

        public decimal Total => LineItems.Sum(item => item.Key.Price * item.Value);

        public Address Recipient { get; set; }

        public Address Sender { get; set; }

        public decimal TotalWeight { get; set; }

        public ShippingStatus ShippingStatus { get; set; } = ShippingStatus.WaitingForPayment;

    }

    public class Address
    {
        public string To { get; set; }
        public string Country { get; set; }
    }
}