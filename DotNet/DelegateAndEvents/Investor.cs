using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents;

public class Investor
{
    public string Name { get; set; }

    public Investor(string name)
    {
        Name = name;
    }

    // Method to handle the stock price change event
    public void ReactToPriceChange(string stockName, decimal newPrice)
    {
        Console.WriteLine($"{Name} received an update: {stockName} is now at ${newPrice}");
    }
}