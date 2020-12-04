using PublisherSubscriber.Publisher;
using System;

namespace PublisherSubscriber.Subscriber
{
    public class DisplayClock : ISubscriber
    {
        private readonly ClockPublisher _clock;

        public DisplayClock(ClockPublisher clock)
        {
            _clock = clock;
        }
        public void AddSubscriber()
        {
            _clock.SecondChange += TimeHasChanged; // subscribe to event
        }
        private void TimeHasChanged(string ti)
        {
            Console.WriteLine("Current Time: " + ti);
        }
    }

}
