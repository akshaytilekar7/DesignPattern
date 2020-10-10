namespace CommandPattern
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
            _product.DecreasePrice(_amount);
        }
    }
}
