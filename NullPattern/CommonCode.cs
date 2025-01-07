using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPattern;

public class Customer
{
    public string Name { get; set; }

    // actual issue start here
    public LoyaltyProgram? LoyaltyProgram { get; set; }

    // so fix is
    //public ILoyaltyProgram LoyaltyProgram { get; set; } = new NullLoyaltyProgram(); // Default to Null Object
}

// actual problems statement this class dont have interface
// onlu solution class have interface
public class LoyaltyProgram : ILoyaltyProgram 
{
    public string Name { get; set; }
    public int Points { get; set; }

    public void RedeemPoints(int points)
    {
        if (Points >= points)
            Points -= points;
    }
}