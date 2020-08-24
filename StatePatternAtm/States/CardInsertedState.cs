using StatePatternAtm.Interface;
using System;

namespace StatePatternAtm.States
{
    public class CardInsertedState : IAtmStateActions
    {
        public IAtmStateActions InsertDebitCard()
        {
            Console.WriteLine("Method - InsertDebitCard");
            Console.WriteLine("State - " + this.GetType().Name);
            Console.WriteLine();
            return this;
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
            Console.WriteLine("pin related operations");

            if (pin == "1234")
            {
                Console.WriteLine("pin is valid, Welcome user");
                Console.WriteLine();
                return this;
            }

            Console.WriteLine("As password is wrong now your card is blocked, cant do any operations");
            Console.WriteLine();
            return new CardBlockState();
        }

        public IAtmStateActions WithdrawMoney(int amount)
        {
            Console.WriteLine("Method - WithdrawMoney " + amount);
            Console.WriteLine("Current State - " + this.GetType().Name);
            Console.WriteLine("WithdrawMoney operations");
            Console.WriteLine();
            return this;
        }
    }
}
