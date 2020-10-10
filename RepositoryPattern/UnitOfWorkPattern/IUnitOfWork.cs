using RepositoryPattern.Models;
using RepositoryPattern.Repositories.Interface;

namespace RepositoryPattern.UnitOfWorkPattern
{
    public interface IUnitOfWork
    {
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Address> AddressRepository { get; }
        void SaveChanges();
    }
}
