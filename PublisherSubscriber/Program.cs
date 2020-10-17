using PublisherSubscriber.Publisher;
using PublisherSubscriber.Subscriber;
using System;
//https://www.akadia.com/services/dotnet_delegates_and_events.html

namespace PublisherSubscriber
{
    public class Program
    {
        public static void Main()
        {
            Clock clock = new Clock();

            ISubscriber dc = new DisplayClock(clock);
            ISubscriber lc = new LogClock(clock);

            lc.AddSubscriber(); // subscribe for event
            dc.AddSubscriber(); // subscribe for event

            clock.GetUpdatedTimeOnSecondChange(); // publish event

            Console.ReadKey();
        }
    }
}

/*
 Q : we can simply print the time rather than raising an event? why we are using delegates?
 A : PS allowed : any number of classes can be notified when an event is raised
    -   subscribing classes do not need to know how the clock(publisher) works
    -   clock(publisher) does not need to know what subscribers are going to do in response to the event
    -   PS are decoupled by the delegate
    -   clock can change how implementation without breaking any of the subscribing classes
    -   and subscribing classes can change implementation without breaking the clock(publisher)
 */
