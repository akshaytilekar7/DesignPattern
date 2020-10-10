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
        public void Subscribe()
        {
            _clock.SecondChange += WriteLogEntry;
        }

        public void WriteLogEntry(string ti)
        {
            Console.WriteLine("Logging to file: " + ti);
        }
    }
}