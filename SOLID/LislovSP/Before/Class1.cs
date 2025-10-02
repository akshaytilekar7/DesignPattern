namespace LislovSP.Before;

public class Order
{
    public virtual void ProcessPayment() => Console.WriteLine("Processing payment for a regular order.");

    public virtual void ShipOrder() => Console.WriteLine("Order shipped.");
}

public class PreOrder : Order
{
    public override void ProcessPayment() => Console.WriteLine("Payment will be processed when the product is available.");

    public override void ShipOrder() => throw new NotSupportedException("Pre-orders cannot be shipped yet!");
}

public class OrderService
{
    public void ProcessOrder(Order order)
    {
        order.ProcessPayment();
        order.ShipOrder(); // ❌ This will break if PreOrder is passed
    }
}

public class Client
{
    public Client()
    {
        // Client code
        var orderService = new OrderService();
        var preOrder = new PreOrder();
        orderService.ProcessOrder(preOrder); // ❌ Throws exception at runtime
    }
}
