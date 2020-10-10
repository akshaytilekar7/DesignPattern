using RepositoryPattern.Models;
using RepositoryPattern.Repositories.Interface;
using System.Linq;

namespace RepositoryPattern.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>
    {
        public CustomerRepository(ShoppingContext context) : base(context)
        {
        }

        public override Customer Update(Customer entity)
        {
            var customer = Context.Customers.Single(c => c.CustomerId == entity.CustomerId);
            customer.Name = entity.Name + " (sys name)";
            return base.Update(customer);
        }
    }
}
