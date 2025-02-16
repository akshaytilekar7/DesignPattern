using StatePatternAtm.Interface;
using System;

namespace StatePatternAtm.States
{
    public class CardBlockState : IAtmStateActions
    {
        public IAtmStateActions InsertDebitCard()
        {
            Console.WriteLine("Method - InsertDebitCard");
            Console.WriteLine("State - " + this.GetType().Name);
            Console.WriteLine();
            return new CardInsertedState();
        }

        public IAtmStateActions EjectDebitCard()
        {
            Console.WriteLine("Method - EjectDebitCard");
            Console.WriteLine("Current State - " + this.GetType().Name);
            Console.WriteLine("New State - CardNotInsertedState");
            Console.WriteLine();
            return new CardNotInsertedState();
        }

        public IAtmStateActions EnterPin(string pin)
        {
            Console.WriteLine("Method - EnterPin");
            Console.WriteLine("Current State - " + this.GetType().Name);
            Console.WriteLine("As Card is blocked, cant do any operations");
            Console.WriteLine();
            return this;
        }

        public IAtmStateActions WithdrawMoney(int amount)
        {
            Console.WriteLine("Method - WithdrawMoney " + amount);
            Console.WriteLine("Current State - " + this.GetType().Name);
            Console.WriteLine("As Card is blocked, cant do any operations");
            Console.WriteLine();
            return this;
        }
    }
}
