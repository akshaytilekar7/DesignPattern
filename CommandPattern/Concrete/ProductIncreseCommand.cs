using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Concrete
{
    public class ProductIncreaseCommand : ICommand
    {
        private readonly Product _product;
        private readonly int _amount;

        public ProductIncreaseCommand(Product product, int amount)
        {
            _product = product;
            _amount = amount;
        }

        public void ExecuteAction()
        {
            _product.Price += _amount;
            Console.WriteLine($"{_product.Name} Add {_amount}");
        }
    }
}
