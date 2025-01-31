namespace LislovSP.After;

public interface IShippingStrategy
{
    void Ship();
}

public class StandardShipping : IShippingStrategy
{
    public void Ship()
    {
        Console.WriteLine("Order shipped via standard shipping.");
    }
}

public class NoShipping : IShippingStrategy
{
    public void Ship()
    {
        Console.WriteLine("Pre-orders cannot be shipped yet.");
    }
}

public class Order
{
    private readonly IShippingStrategy _shippingStrategy;

    public Order(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment.");
    }

    public void ShipOrder()
    {
        _shippingStrategy.Ship();
    }
}

public class Client
{
    public void Main()
    {
        // Client code
        var regularOrder = new Order(new StandardShipping());
        var preOrder = new Order(new NoShipping());

        regularOrder.ProcessPayment();
        regularOrder.ShipOrder(); // ✅ Works fine

        preOrder.ProcessPayment();
        preOrder.ShipOrder(); // ✅ No exception, just logs a message

    }
}

/*
   in before code All Order are shipping
   but after code by looking at client code we can easly say all Order are not for ship means it client repos what they want to do 
✔ LSP Compliant – Order behaves correctly regardless of its shipping type.
✔ More Flexible – We can introduce more shipping strategies without modifying the Order class.
✔ Easier to Maintain – No unnecessary overrides, making the code cleaner and more scalable.

This is how composition replaces inheritance effectively in a real-world, production-level scenario.

*/