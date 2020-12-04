using System;

namespace DelegateEventInDI.Events
{
    class EventUse
    {
        void InvertedMember2()
        {
            Console.WriteLine("E Oh I dint know when actually the call to InvertedMember2 occurred");
        }

        public EventUse()
        {
            Event obj = new Event();

            obj.InvertedMember1 += delegate ()
            {
                Console.WriteLine("E Oh I dint know when actually the call to InvertedMember1 occurred");
            };

            obj.InvertedMember2 += InvertedMember2;
            obj.MyMethod();


        }
    }
}
