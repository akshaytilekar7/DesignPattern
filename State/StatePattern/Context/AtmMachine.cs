using StatePattern.ConcreteClass;
using StatePattern.Interface;
using System;

namespace StatePattern.Context
{
    public class AtmMachine : IAtmState
    {
        public IAtmState AtmMachineState { get; set; }

        public AtmMachine()
        {
            AtmMachineState = new DebitCardNotInsertedState();
        }

        public void InsertDebitCard()
        {
            AtmMachineState.InsertDebitCard();

            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'

            if (AtmMachineState is DebitCardNotInsertedState)
            {
                AtmMachineState = new DebitCardInsertedState();

                Console.WriteLine("ATM Machine internal state has been moved to : "
                                  + AtmMachineState.GetType().Name);
            }
        }

        public void EjectDebitCard()
        {
            AtmMachineState.EjectDebitCard();

            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'

            if (AtmMachineState is DebitCardInsertedState)
            {

                AtmMachineState = new DebitCardNotInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                  + AtmMachineState.GetType().Name);
            }
        }

        public void EnterPin()
        {
            AtmMachineState.EnterPin();
        }
        public void WithdrawMoney()
        {
            AtmMachineState.WithdrawMoney();
        }
    }
}