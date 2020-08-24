namespace StatePattern.Interface
{
    public interface IAtmState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
