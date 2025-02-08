namespace Generics_Examples;
public class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void GetDetails() => Console.WriteLine($"Customer: {Name}, ID: {Id}");
}

public class Order : IEntity
{
    public int Id { get; set; }
    public double Amount { get; set; }

    public void GetDetails() => Console.WriteLine($"Order ID: {Id}, Amount: {Amount}");
}

public class Service
{
    public void ProcessEntity<T>(T entity) where T : class, IEntity
    {
        Console.WriteLine("Processing entity...");
        entity.GetDetails(); // ✅ Can access IEntity methods
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Service service = new Service();

        Customer cust = new Customer { Id = 1, Name = "Alice" };
        Order order = new Order { Id = 101, Amount = 250.75 };

        service.ProcessEntity(cust);    
        service.ProcessEntity(order);
        // service.ProcessEntity(123); // ❌ Compile-time error (int is not a class)
        // service.ProcessEntity(new StructEntity()); // ❌ Compile-time error (structs not allowed)

        Console.WriteLine("Hello, World!");
        Console.ReadKey();
    }
}
