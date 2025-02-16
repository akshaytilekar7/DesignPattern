using FactoryPatternNew.Factory;

namespace FactoryPatternNew;

public class Program
{
    static void Main(string[] args)
    {
        ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

        Console.WriteLine("CardType : " + cardDetails.GetCardType());
        Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
        Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());

        Console.WriteLine("Completed");
        Console.ReadLine();
    }
}
