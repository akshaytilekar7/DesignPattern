using System;
using System.Collections.Generic;
using System.Linq;
namespace NullPattern;

public interface ILoyaltyProgram
{
    void RedeemPoints(int points);
}


public class NullLoyaltyProgram : ILoyaltyProgram
{
    public void RedeemPoints(int points) => Console.WriteLine("No loyalty program available.");
}

internal class Solution
{
    public static void Run()
    {
        var customers = new List<Customer>
        {
            new Customer { Name = "Alice", LoyaltyProgram = new LoyaltyProgram { Name = "Gold", Points = 100 } },
            new Customer { Name = "Bob" } // Defaults to NullLoyaltyProgram
        };

        foreach (var customer in customers)
            customer.LoyaltyProgram.RedeemPoints(50); // No null checks needed!
    }
}
