using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories.Interface;
using RepositoryPattern.UnitOfWorkPattern;

namespace RepositoryPattern.UnitTests
{
    [TestClass]
    public class OrderTestsUnitOfWork
    {
        [TestMethod]
        public void CanCreateOrderWithCorrectModel()
        {
            // ARRANGE 
            var addressRepository = new Mock<IRepository<Address>>();
            var customerRepository = new Mock<IRepository<Customer>>();
            var unitOfWork = new Mock<IUnitOfWork>();

            unitOfWork.Setup(uow => uow.CustomerRepository).Returns(() => customerRepository.Object);
            unitOfWork.Setup(uow => uow.AddressRepository).Returns(() => addressRepository.Object);

            var action = new Program(unitOfWork.Object);

            // ACT
            action.CreateWIthUnitOfWork();

            // ASSERT
            addressRepository.Verify(r => r.Add(It.IsAny<Address>()), Times.AtLeastOnce());
        }
    }
}
