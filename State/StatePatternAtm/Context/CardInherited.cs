using StatePatternAtm.Interface;

namespace StatePatternAtm.Context
{
    // NOT : its not mandatory to inherit from interface IAtmStateActions 
    // I just tried and works only difference is u need to return from method
    public class CardInherited : IAtmStateActions
    {
        private readonly IAtmStateActions _atmStateActions;

        public CardInherited(IAtmStateActions atmStateActions)
        {
            _atmStateActions = atmStateActions;
        }

        public IAtmStateActions InsertDebitCard()
        {
            return this._atmStateActions.InsertDebitCard();
        }

        public IAtmStateActions EnterPin(string pin)
        {
            return this._atmStateActions.EnterPin(pin);
        }

        public IAtmStateActions WithdrawMoney(int amount)
        {
            return this._atmStateActions.WithdrawMoney(amount);
        }

        public IAtmStateActions EjectDebitCard()
        {
            return this._atmStateActions.EjectDebitCard();
        }
    }
}
