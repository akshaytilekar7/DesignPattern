using System.Collections.Generic;

namespace DecoratorPatternOrder.Component
{
    public abstract class Order
    {
        protected List<Product> Products = new List<Product>
        {
            new Product {Name = "Phone", Price = 10},
            //new Product {Name = "Tablet", Price = 20},
            //new Product {Name = "PC", Price = 30}
        };

        public abstract double CalculateTotalOrderPrice();
    }
}
