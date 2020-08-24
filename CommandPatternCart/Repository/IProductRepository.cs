using CommandPatternCart.Models;
using System.Collections.Generic;

namespace CommandPatternCart.Repository
{
    public interface IProductRepository
    {
        Product FindBy(string id);
        int GetStockFor(string Id);
        IEnumerable<Product> All();
        void DecreaseStockBy(string id, int amount);
        void IncreaseStockBy(string id, int amount);
    }
}
