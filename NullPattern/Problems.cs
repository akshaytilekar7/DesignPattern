namespace NullPattern;

internal class Problems
{
    static void Main(string[] args)
    {
        var customers = new List<Customer>
        {
            new Customer { Name = "Alice", LoyaltyProgram = new LoyaltyProgram { Name = "Gold", Points = 100 } },
            new Customer { Name = "Bob" } // NO LOYALTY PROGRAM
        };

        foreach (var customer in customers)
        {
            if (customer.LoyaltyProgram != null) // ALSO VOILATES LSP so Use NUll pattern
                customer.LoyaltyProgram.RedeemPoints(50);
            else
                Console.WriteLine($"{customer.Name} does not have a loyalty program.");
        }
    }
}
