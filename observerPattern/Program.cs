using observerPattern.ConcreateObservable;
using observerPattern.ConcreateObserver;
using System;

namespace observerPattern
{
    public class ProgramB
    {
        static void Main(string[] args)
        {

            WheatherStation station = new WheatherStation();

            PrintMediaDisplay printMediaDisplay = new PrintMediaDisplay(station);
            NewsChannleDisplay newsChannleDisplay = new NewsChannleDisplay(station);

            station.Add(printMediaDisplay);
            station.Add(newsChannleDisplay);

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(10);

            var timer = new System.Threading.Timer((e) =>
            {
                station.Notify();
            }, null, startTimeSpan, periodTimeSpan);


            Console.ReadKey();


        }
    }
}
