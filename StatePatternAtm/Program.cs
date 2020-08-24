using StatePatternAtm.Context;
using StatePatternAtm.Interface;
using StatePatternAtm.States;
using System;

namespace StatePatternAtm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------CARD INHERITED EXAMPLE START -------");

            IAtmStateActions cardInherited = new CardInherited(new CardNotInsertedState());
            cardInherited = cardInherited.EjectDebitCard();
            cardInherited = cardInherited.EnterPin("1234");
            cardInherited = cardInherited.WithdrawMoney(500);
            Console.WriteLine("-------");

            cardInherited = cardInherited.InsertDebitCard();
            cardInherited = cardInherited.EnterPin("1234");
            cardInherited = cardInherited.WithdrawMoney(1000);
            cardInherited = cardInherited.EjectDebitCard();
            cardInherited = cardInherited.InsertDebitCard();
            cardInherited = cardInherited.WithdrawMoney(1001110);

            Console.WriteLine("-------CARD INHERITED EXAMPLE END -------");

            Console.WriteLine("-------NORMAL CARD EXAMPLE START -------");


            Card card = new Card(new CardNotInsertedState());

            card.InsertDebitCard();
            card.EnterPin("1234");
            card.InsertDebitCard();
            card.WithdrawMoney(5000);
            card.EjectDebitCard();
            Console.WriteLine("-------NORMAL CARD EXAMPLE END -------");

            Console.ReadLine();
        }
    }
}
