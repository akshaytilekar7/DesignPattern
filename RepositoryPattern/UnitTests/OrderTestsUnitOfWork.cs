using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyShop.Domain.Models;
using MyShop.Infrastructure.Repositories;
using RepositoryPattern.UnitOfWorkPattern;

namespace MyShop.Web.Tests
{
    [TestClass]
    public class OrderTestsUnitOfWork
    {
        [TestMethod]
        public void CanCreateOrderWithCorrectModel()
        {
            // ARRANGE 
            var orderRepository = new Mock<IRepository<Order>>();
            var productRepository = new Mock<IRepository<Product>>();
            var customerRepository = new Mock<IRepository<Customer>>();
            var unitOfWork = new Mock<IUnitOfWork>();

            unitOfWork.Setup(uow => uow.CustomerRepository).Returns(() => customerRepository.Object);
            unitOfWork.Setup(uow => uow.OrderRepository).Returns(() => orderRepository.Object);
            unitOfWork.Setup(uow => uow.ProductRepository).Returns(() => productRepository.Object);

            var action = new Program(unitOfWork.Object);

            // ACT
            action.CreateWIthUnitOfWork(new CreateOrderModel());

            // ASSERT
            orderRepository.Verify(r => r.Add(It.IsAny<Order>()), Times.AtLeastOnce());
        }
    }
}
