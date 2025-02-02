namespace DelegateAndEvents;


class Program
{
    static void Main(string[] args)
    {
        // Create a stock
        Stock appleStock = new Stock("AAPL", 150.00m);

        // Create investors
        Investor investor1 = new Investor("John Doe");
        Investor investor2 = new Investor("Jane Smith");

        // Subscribe investors to the stock's price change event
        appleStock.PriceChanged += investor1.ReactToPriceChange;
        appleStock.PriceChanged += investor2.ReactToPriceChange;

        // DELEGATE ISSUE WE CAN CHANGE THE DELGATE BY CLIENT
        //appleStock.PriceChanged = null; // This will remove all subscribers!
        //appleStock.PriceChanged?.Invoke("AAPL", 100.00m); // External code can invoke the delegate

        // Simulate price changes
        appleStock.Price = 155.00m; // Both investors will be notified
        appleStock.Price = 160.00m; // Both investors will be notified again


       

        Console.WriteLine("Done,,,,,,,,,,");
        Console.ReadLine();
    }
}