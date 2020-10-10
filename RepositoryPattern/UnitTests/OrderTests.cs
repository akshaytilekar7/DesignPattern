using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories.Interface;

namespace RepositoryPattern.UnitTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void CanCreateOrderWithCorrectModel()
        {
            // ARRANGE 
            var addressRepository = new Mock<IRepository<Address>>();
            var customerRepository = new Mock<IRepository<Customer>>();

            var orderController = new Program(customerRepository.Object, addressRepository.Object);

            // ACT
            orderController.Create();

            // ASSERT
            addressRepository.Verify(r => r.Add(It.IsAny<Address>()), Times.AtLeastOnce());
        }
    }
}
