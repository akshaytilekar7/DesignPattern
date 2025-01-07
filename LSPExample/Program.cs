namespace LSPExample;

internal class Program
{
    static void Main(string[] args)
    {
        // works
        Service obj1 = new Service(new CreditCardPayment());
        obj1.Process(100);

        // works
        Service obj2 = new Service(new PayPalPayment());
        obj2.Process(100);

        // works
        Service obj3 = new Service(new BankTransferPayment());
        obj3.Process(100);

        Console.ReadKey();
    }
}
