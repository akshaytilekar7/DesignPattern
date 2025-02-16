using StatePattern.Interface;
using System;

namespace StatePattern.ConcreteClass
{
    public class DebitCardNotInsertedState : IAtmState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }

        public void EjectDebitCard()
        {
            Console.WriteLine("NO ---- You cannot eject the Debit CardNo, as no Debit Card in ATM Machine slot");
        }

        public void EnterPin()
        {
            Console.WriteLine("NO ---- you cannot enter the pin, as No Debit Card in ATM Machine slot");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("NO ---- you cannot withdraw money, as No Debit Card in ATM Machine slot");
        }
    }
}
