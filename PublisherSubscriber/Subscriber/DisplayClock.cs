using PublisherSubscriber.Publisher;
using System;

namespace PublisherSubscriber.Subscriber
{
    public class DisplayClock
    {
        private readonly Clock _clock;

        public DisplayClock(Clock clock)
        {
            _clock = clock;
        }
        public void Subscribe()
        {
            _clock.SecondChange += TimeHasChanged;
        }

        public void TimeHasChanged(string ti)
        {
            Console.WriteLine("Current Time: " + ti);
        }
    }

}
