namespace StatePatternAtm.Interface
{
    public interface IAtmStateActions
    {
        IAtmStateActions InsertDebitCard();
        IAtmStateActions EjectDebitCard();
        IAtmStateActions EnterPin(string pin);
        IAtmStateActions WithdrawMoney(int amount);
    }
}
