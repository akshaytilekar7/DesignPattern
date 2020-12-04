using System;

namespace DelegateEventInDI.Delegates
{
    public class DelegateUse
    {
        void Method1()
        {
            Console.WriteLine("Oh I dint know when actually the call to InvertedMember1 occurred");
        }
        public DelegateUse()
        {

            void Method2()
            {
                Console.WriteLine("Oh I dint know when actually the call to InvertedMember2 occurred");
            }

            Delegate obj = new Delegate(Method1, Method2);
            obj.MyMethod();
        }
    }
}
