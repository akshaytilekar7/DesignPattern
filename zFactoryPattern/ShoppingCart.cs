﻿//using zFactoryPattern.Commerce;
//using zFactoryPattern.Shipping;

//namespace zFactoryPattern
//{
//    public class ShoppingCart
//    {
//        private readonly Order order;

//        public ShoppingCart(Order order)
//        {
//            this.order = order;
//        }

//        public string Finalize()
//        {
//            var shippingProvider = ShippingProviderFactory.CreateShippingProvider(order.Sender.Country);

//            order.ShippingStatus = ShippingStatus.ReadyForShippment;

//            return shippingProvider.GenerateShippingLabelFor(order);
//        }
//    }
//}
