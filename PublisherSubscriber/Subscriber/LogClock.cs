using PublisherSubscriber.Publisher;
using System;

namespace PublisherSubscriber.Subscriber
{
    public class LogClock
    {
        private readonly Clock _clock;

        public LogClock(Clock clock)
        {
            _clock = clock;
        }
        public void AddSubscriber()
        {
            _clock.SecondChange += WriteLogEntry; // subscribe to event
        }

        public void WriteLogEntry(string ti)
        {
            Console.WriteLine("Logging to file: " + ti);
        }
    }
}