using observerPattern.ConcreateObserver;
using observerPattern.Interface;
using System;

namespace observerPattern.ConcreateObservable
{
    public class NewsChannleDisplay : IObserver
    {
        private readonly WheatherStation wheatherStation;
        public NewsChannleDisplay(WheatherStation wheatherStation)
        {
            this.wheatherStation = wheatherStation;
        }

        public void update()
        {
            var temp = wheatherStation.GetWeather();
            var str = "Breaking news!!! \n weather today :" + DateTime.UtcNow + " is " + temp;
            Console.WriteLine(str);
        }
    }


}
