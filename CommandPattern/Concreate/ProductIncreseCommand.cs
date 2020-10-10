namespace CommandPattern
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
            _product.IncreasePrice(_amount);
        }
    }
}
