using PublisherSubscriber.Publisher;
using System;

namespace PublisherSubscriber.Subscriber
{
    public class LogClock : ISubscriber
    {
        private readonly ClockPublisher _clock;

        public LogClock(ClockPublisher clock)
        {
            _clock = clock;
        }
        public void AddSubscriber()
        {
            _clock.SecondChange += WriteLogEntry; // subscribe to event
        }

        private void WriteLogEntry(string ti)
        {
            Console.WriteLine("Logging to file: " + ti);
        }
    }
}