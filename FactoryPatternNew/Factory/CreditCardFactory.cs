namespace FactoryPatternNew.Factory;

public class CreditCardFactory
{
    public static ICreditCard GetCreditCard(string cardType)
    {
        if (cardType == "Titanium")
            return new Titanium();
        else if (cardType == "Platinum")
            return new Platinum();

        throw new ArgumentException();
    }
}