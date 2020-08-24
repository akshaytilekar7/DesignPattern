using StatePatternAtm.Interface;

namespace StatePatternAtm.Context
{
    public class Card
    {
        private IAtmStateActions _atmStateActions;

        public Card(IAtmStateActions atmStateActions)
        {
            _atmStateActions = atmStateActions;
        }

        public void InsertDebitCard()
        {
            this._atmStateActions = this._atmStateActions.InsertDebitCard();
        }

        public void EnterPin(string pin)
        {
            this._atmStateActions = this._atmStateActions.EnterPin(pin);
        }

        public void WithdrawMoney(int amount)
        {
            this._atmStateActions = this._atmStateActions.WithdrawMoney(amount);
        }

        public void EjectDebitCard()
        {
            this._atmStateActions = this._atmStateActions.EjectDebitCard();
        }
    }
}