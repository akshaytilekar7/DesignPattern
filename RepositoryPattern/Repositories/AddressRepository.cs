using RepositoryPattern.Models;
using RepositoryPattern.Repositories.Interface;

namespace RepositoryPattern.Repositories
{
    public class AddressRepository : GenericRepository<Address>
    {
        public AddressRepository(ShoppingContext context) : base(context)
        {
        }
    }
}
