using RepositoryPattern.Models;
using RepositoryPattern.Repositories;
using RepositoryPattern.Repositories.Interface;
using RepositoryPattern.UnitOfWorkPattern;
using System;
using System.Linq;

namespace RepositoryPattern
{
    public class Program
    {
        public readonly IRepository<Customer> CustomerRepository;
        public readonly IRepository<Address> AddressRepository;

        readonly ShoppingContext context = new ShoppingContext();
        private readonly IUnitOfWork unitOfWork;

        public static void Main()
        {

        }

        //only repo
        public Program(IRepository<Customer> c, IRepository<Address> address)
        {
            CustomerRepository = new CustomerRepository(context);
            AddressRepository = new AddressRepository(context);
            Create();
            GetCustomer(new Guid());
        }

        // Unit of work [shares a single database context and serves one purpose; .
        // to make sure that when we use multiple repositories.]
        public Program(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateWIthUnitOfWork()
        {
            var customer = unitOfWork.CustomerRepository.Find(c => c.Name == "A").FirstOrDefault();

            if (customer != null)
            {
                //Update property of object
                customer.Name = "update field with new data";
                unitOfWork.CustomerRepository.Update(customer);
            }
            else
            {
                var customer1 = new Customer { Name = "A" };
            }

            var order = new Address();

            unitOfWork.AddressRepository.Add(order);
            unitOfWork.SaveChanges();

        }

        public void Create()
        {
            AddressRepository.Add(new Address());
            //AddressRepository.SaveChanges();
        }
        public void GetCustomer(Guid? id)
        {
            if (id == null)
            {
                var customers = CustomerRepository.All();
            }

            var customer = CustomerRepository.Get(id.Value);

            //Order 
            var orders = AddressRepository.Find(order => order.AddressId > 0);
        }
    }
}

// for Core startup.cs
//services.AddTransient<ShoppingContext>();
//services.AddTransient<IRepository<Customer>, CustomerRepository>();
//services.AddTransient<IRepository<Order>, OrderRepository>();
//services.AddTransient<IRepository<Product>, ProductRepository>();
//services.AddTransient<IUnitOfWork, UnitOfWork>();
