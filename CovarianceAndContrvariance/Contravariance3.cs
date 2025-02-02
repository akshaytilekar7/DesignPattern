namespace CovarianceAndContrvariance123;

public class Base { }
public class Child : Base { }

// Contravariant delegate with the 'in' keyword
public delegate void MyDelegate<in T>(T obj);

public class Service
{
    public static void ProcessBase(Base obj)
    {
        Console.WriteLine("Processing Base object");
    }

    public static void ProcessChild(Child obj)
    {
        Console.WriteLine("Processing Child object");
    }
}

public class Client
{
    public Client()
    {
        // Create a delegate that expects a Child parameter
        MyDelegate<Child> myDelegate;

        // Assign the ProcessBase method to the delegate
        myDelegate = Service.ProcessBase; // Valid: Contravariance in action
        myDelegate(new Child()); // Calls ProcessBase with a Child object
    }
}

public class Program
{
    public static void Main12(string[] args)
    {
        Client client = new Client();

        Console.WriteLine("Done");

        Console.ReadLine();
    }
}