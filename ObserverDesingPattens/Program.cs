using ObserverDesingPattens.Contract;

namespace ObserverDesingPattens;

class Program
{
    static void Main(string[] args)
    {
        var orderProcessor = new OrderProcessor();

        var emailNotification = new EmailNotification();
        var inventoryUpdate = new InventoryUpdate();

        orderProcessor.Add(emailNotification);
        orderProcessor.Add(inventoryUpdate);

        orderProcessor.Process("ORD12345");


        orderProcessor.Process("ORD67890");
    }
}
