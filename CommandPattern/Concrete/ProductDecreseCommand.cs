using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Concrete
{
    public class ProductDecreaseCommand : ICommand
    {
        private readonly Product _product;
        private readonly int _amount;

        public ProductDecreaseCommand(Product product, int amount)
        {
            _product = product;
            _amount = amount;
        }

        public void ExecuteAction()
        {
            if (_amount < _product.Price)
            {
                _product.Price -= _amount;
                Console.WriteLine($"{_product.Name} decrease {_amount}");
            }
        }
    }
}
