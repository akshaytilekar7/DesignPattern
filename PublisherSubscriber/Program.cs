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

            DisplayClock dc = new DisplayClock(clock);
            LogClock lc = new LogClock(clock);

            lc.Subscribe();
            dc.Subscribe();

            var timer = new System.Threading.Timer((e) =>
            {
                clock.Notify(DateTime.Now.ToLongTimeString());
            }, null, TimeSpan.Zero, TimeSpan.FromSeconds(2));

            Console.ReadKey();

        }
    }
}
