//using zFactoryMethodPattern.Commerce;
//using zFactoryMethodPattern.Shipping.Factories;

//namespace zFactoryMethodPattern
//{
//    // NO USE 
//    public class ShoppingCart
//    {
//        private readonly Order order;
//        private readonly ShippingProviderFactory shippingProviderFactory;

//        public ShoppingCart(Order order, ShippingProviderFactory shippingProviderFactory)
//        {
//            this.order = order;
//            this.shippingProviderFactory = shippingProviderFactory;
//        }

//        public string Finalize()
//        {
//            var shippingProvider = shippingProviderFactory.CreateShippingProvider(order.Sender.Country);

//            order.ShippingStatus = ShippingStatus.ReadyForShipment;

//            return shippingProvider.GenerateShippingLabelFor(order);
//        }
//    }
//}
