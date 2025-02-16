namespace FactoryPatternNew.Factory;
public class MoneyBack : ICreditCard
{
    public string GetCardType()
    {
        return "MoneyBack";
    }
    public int GetCreditLimit()
    {
        return 50;
    }
    public int GetAnnualCharge()
    {
        return 20;
    }
}
