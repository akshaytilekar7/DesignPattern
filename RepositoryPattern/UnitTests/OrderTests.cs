using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyShop.Domain.Models;
using MyShop.Infrastructure.Repositories;

namespace MyShop.Web.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void CanCreateOrderWithCorrectModel()
        {
            // ARRANGE 
            var orderRepository = new Mock<IRepository<Order>>();
            var productRepository = new Mock<IRepository<Product>>();
            var customerRepository = new Mock<IRepository<Customer>>();

            var orderController = new Program(orderRepository.Object, productRepository.Object);

            var createOrderModel = new CreateOrderModel { };

            // ACT
            orderController.Create(createOrderModel);

            // ASSERT
            orderRepository.Verify(r => r.Add(It.IsAny<Order>()), Times.AtLeastOnce());
        }
    }
}
