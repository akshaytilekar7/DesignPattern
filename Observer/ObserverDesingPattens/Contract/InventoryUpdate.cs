namespace ObserverDesignPattens.Contract;

public class InventoryUpdate : INotificationSubscriber
{
    public void Update(string message)
    {
        Console.WriteLine($"Inventory Update: {message}");
        // Simulate updating inventory stock
    }
}
