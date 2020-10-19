using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);

            Execute(modifyPrice, new ProductIncreaseCommand(product, 100));

            Execute(modifyPrice, new ProductIncreaseCommand(product, 50));

            Execute(modifyPrice, new ProductDecreaseCommand(product, 25));

            Console.WriteLine(product);
        }

        private static void Execute(ModifyPrice modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
/*

    - serve request as object
    - save actions/command in as object and later executes it
    - supprt undo redo opearions

*/