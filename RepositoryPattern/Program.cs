using MyShop.Domain.Models;
using MyShop.Infrastructure;
using MyShop.Infrastructure.Repositories;
using RepositoryPattern.UnitOfWorkPattern;
using System;
using System.Linq;

namespace MyShop.Web
{
    public class Program
    {
        public readonly IRepository<Customer> _customerRepository;
        public readonly IRepository<Order> _orderRepository;
        public readonly IRepository<Product> _productRepository;

        ShoppingContext context = new ShoppingContext();
        private IUnitOfWork unitOfWork;

        public static void Main(string[] args) { }

        public Program(IRepository<Order> c, IRepository<Product> g)
        {
            _customerRepository = new CustomerRepository(context);
            _orderRepository = new OrderRepository(context);
            _productRepository = new ProductRepository(context);
            Create(new CreateOrderModel());
            GetCustomer(new Guid());
        }

        public Program(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateWIthUnitOfWork(CreateOrderModel model)
        {
            var customer = unitOfWork.CustomerRepository.Find(c => c.Name == "A").FirstOrDefault();

            if (customer != null)
            {
                //Update property of object
                customer.ShippingAddress = "update field";
                unitOfWork.CustomerRepository.Update(customer);
            }
            else
                customer = new Customer { Name = "A" };
            //Create new customer obj as it is not exist in DB

            var order = new Order { Customer = customer };

            unitOfWork.OrderRepository.Add(order);
            unitOfWork.SaveChanges();

        }

        public void Create(CreateOrderModel model)
        {
            _orderRepository.Add(new Order());
            _orderRepository.SaveChanges();
        }
        public void GetCustomer(Guid? id)
        {
            if (id == null)
            {
                var customers = _customerRepository.All();
            }

            var customer = _customerRepository.Get(id.Value);

            //Order 
            var orders = _orderRepository.Find(order => order.OrderDate > DateTime.UtcNow.AddDays(-1));

            //priduct
            var products = _productRepository.All();

        }
    }
}

// for Core startup.cs
//services.AddTransient<ShoppingContext>();
//services.AddTransient<IRepository<Customer>, CustomerRepository>();
//services.AddTransient<IRepository<Order>, OrderRepository>();
//services.AddTransient<IRepository<Product>, ProductRepository>();
//services.AddTransient<IUnitOfWork, UnitOfWork>();
