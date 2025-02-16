using observerPattern.ConcreteObservable;
using observerPattern.ConcreteObserver;
using System;

namespace observerPattern
{
    public class ProgramB
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();

            PrintMediaDisplay printMediaDisplay = new PrintMediaDisplay(station);
            NewsChannelDisplay newsChannelDisplay = new NewsChannelDisplay(station);

            station.Add(printMediaDisplay);
            station.Add(newsChannelDisplay);

            var timer = new System.Threading.Timer((e) =>
            {
                station.Notify();
            }, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));

            Console.ReadKey();
        }
    }
}
