namespace SRP.Example1.NotUsed;

public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        if (order.IsValid)
        {
            SaveOrder(order);
            SendEmail(order);
        }
    }

    private void SaveOrder(Order order) { /* Database logic */ }
    private void SendEmail(Order order) { /* Email logic */ }
}


