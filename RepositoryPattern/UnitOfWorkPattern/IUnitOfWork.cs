using MyShop.Domain.Models;
using MyShop.Infrastructure.Repositories;

namespace RepositoryPattern.UnitOfWorkPattern
{
    public interface IUnitOfWork
    {
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Order> OrderRepository { get; }
        IRepository<Product> ProductRepository { get; }

        void SaveChanges();
    }
}
