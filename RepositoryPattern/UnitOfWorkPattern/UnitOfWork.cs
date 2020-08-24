using MyShop.Domain.Models;
using MyShop.Infrastructure;
using MyShop.Infrastructure.Repositories;

namespace RepositoryPattern.UnitOfWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private ShoppingContext context;
        public UnitOfWork(ShoppingContext context)
        {
            this.context = context;
        }

        private IRepository<Order> orderRepository;
        private IRepository<Customer> customerRepository;
        private IRepository<Product> productRepository;

        public IRepository<Customer> CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(context);
                }

                return customerRepository;
            }
        }

        public IRepository<Order> OrderRepository
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository(context);
                }

                return orderRepository;
            }
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(context);
                }

                return productRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
