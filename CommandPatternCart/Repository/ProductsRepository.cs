using CommandPatternCart.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommandPatternCart.Repository
{
    public class ProductsRepository : IProductRepository
    {
        private List<Product> products;
        public ProductsRepository()
        {
            products = GetProductsFromDb();
        }

        public IEnumerable<Product> All()
        {
            return products;
        }

        public void DecreaseStockBy(string id, int amount)
        {
            if (products.All(x => x.ArticleId != id)) return;
            var p = products.First(x => x.ArticleId == id);
            p.Quantity = p.Quantity - amount;
        }

        public Product FindBy(string id)
        {
            throw new System.NotImplementedException();
        }

        public int GetStockFor(string Id)
        {
            throw new System.NotImplementedException();
        }

        public void IncreaseStockBy(string id, int amount)
        {
            if (products.All(x => x.ArticleId != id)) return;
            products.First(x => x.ArticleId == id).Quantity = amount;
        }

        private List<Product> GetProductsFromDb()
        {
            return new List<Product>()
            {

                new Product() {Id = 1, ArticleId ="A1", Name = "i phone 5", Price = 100, Quantity = 10},
                new Product() {Id = 2, ArticleId ="A2", Name = "i phone 11", Price = 200, Quantity = 8},
                new Product() {Id = 3, ArticleId ="A3", Name = "i phone x", Price = 300, Quantity = 5}
            };
        }
    }
}
